using AutomaticInterface;

using Forge.Config;
using Forge.Game.Config.Native;
using Forge.Native;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Forge.Game.Config {
    public interface IConfigApi {
        List<string> GetSectionNames();
        List<string> GetConfigNamesForSection(string section);

        CConfigVar.VarType GetSettingType(string section, string setting);
        int GetSettingInt(string section, string setting, int defaultValue);
        float GetSettingFloat(string section, string setting, float defaultValue);
        string GetSettingString(string section, string setting, string defaultValue);
        int[] GetSettingIntArray(string section, string setting, int[] defaultValue);

        nint GetConfigByName(string sectionName, string configName);
    }

    internal sealed unsafe class ConfigApi : IConfigApi {
        private IGameValues gameValues;
        private CConfigManager* configManager;

        public ConfigApi(IGameValues gameValues) {
            this.gameValues = gameValues;

            configManager = *(CConfigManager**)gameValues.GetPointer<CConfigManager>(0x1054C8C);
        }

        private CConfigSection*[] GetSections() {
            ConfigSectionList sectionList = configManager->sectionList;
            CConfigSectionListNode* currentSection = sectionList.start->next;
            if (currentSection == configManager->sectionList.start) {
                // No entries!
                return [];
            }

            CConfigSection*[] sections = new CConfigSection*[sectionList.length];
            int i = 0;
            while (currentSection != null && currentSection != configManager->sectionList.start) {
                CConfigSection* configSection = currentSection->data;
                sections[i++] = configSection;
                currentSection = currentSection->next;
            }

            return sections;
        }

        public List<string> GetSectionNames() {
            var sections = GetSections();
            List<string> sectionNames = new List<string>();
            foreach (CConfigSection* section in sections) {
                if (section == null)
                    continue;

                sectionNames.Add(section->name.Text);
            }
            return sectionNames;
        }

        public List<string> GetConfigNamesForSection(string section) {
            CConfigVarMapNode*[] configs = GetConfigsInSection(section);

            List<string> configNames = new List<string>();
            foreach (CConfigVarMapNode* config in configs) {
                if (config == null)
                    continue;
                configNames.Add(config->key.Text);
            }

            return configNames;
        }

        public CConfigVar.VarType GetSettingType(string section, string setting) {
            nint pSection = Marshal.StringToHGlobalAnsi(section);
            nint pSetting = Marshal.StringToHGlobalAnsi(setting);
            CConfigVar* config = configManager->GetConfigVar((sbyte*)pSection, (sbyte*)pSetting);
            Marshal.FreeHGlobal(pSection);
            Marshal.FreeHGlobal(pSetting);

            return config == null ? CConfigVar.VarType.Unknown : config->Type;
        }

        public int GetSettingInt(string section, string setting, int defaultValue) {
            nint pSection = Marshal.StringToHGlobalAnsi(section);
            nint pSetting = Marshal.StringToHGlobalAnsi(setting);
            int settingInt = configManager->RetrieveIntSetting((sbyte*)pSection, (sbyte*)pSetting, defaultValue);
            Marshal.FreeHGlobal(pSection);
            Marshal.FreeHGlobal(pSetting);

            return settingInt;
        }

        public float GetSettingFloat(string section, string setting, float defaultValue) {
            nint pSection = Marshal.StringToHGlobalAnsi(section);
            nint pSetting = Marshal.StringToHGlobalAnsi(setting);
            float settingFloat = (float)configManager->RetrieveFloatSetting((sbyte*)pSection, (sbyte*)pSetting, defaultValue);
            Marshal.FreeHGlobal(pSection);
            Marshal.FreeHGlobal(pSetting);
            return settingFloat;
        }

        public string GetSettingString(string section, string setting, string defaultValue) {
            nint pSection = Marshal.StringToHGlobalAnsi(section);
            nint pSetting = Marshal.StringToHGlobalAnsi(setting);
            CConfigVar* config = configManager->GetConfigVar((sbyte*)pSection, (sbyte*)pSetting);
            Marshal.FreeHGlobal(pSection);
            Marshal.FreeHGlobal(pSetting);

            if (config == null)
                return defaultValue;

            if (config->Type != CConfigVar.VarType.String) // TODO: Maybe add error?
                return defaultValue;

            CConfigVarString* stringConfig = (CConfigVarString*)config;
            return stringConfig->value.Text;
        }

        public int[] GetSettingIntArray(string section, string setting, int[] defaultValue) {
            nint pSection = Marshal.StringToHGlobalAnsi(section);
            nint pSetting = Marshal.StringToHGlobalAnsi(setting);
            CConfigVar* config = configManager->GetConfigVar((sbyte*)pSection, (sbyte*)pSetting);
            Marshal.FreeHGlobal(pSection);
            Marshal.FreeHGlobal(pSetting);
            if (config == null)
                return defaultValue;
            if (config->Type != CConfigVar.VarType.IntArray) // TODO: Maybe add error?
                return defaultValue;
            int* intArrayConfig = config->GetArray();
            int size = config->itemCount;
            int[] values = new int[size];
            for (int i = 0; i < size; i++) {
                values[i] = intArrayConfig[i];
            }

            return values;
        }

        public unsafe nint GetConfigByName(string sectionName, string configName) {
            CConfigSection* section = GetSectionByName(sectionName);
            if (section == null)
                return nint.Zero;

            ConfigVarMap* configMap = &section->configVarMap;
            if (configMap == null)
                return nint.Zero;

            CConfigVarMapNode* result, root, index;

            result = configMap->root;
            root = configMap->root;
            index = configMap->root->left;
            while (index->isUnpopulatedNode == 0) {
                string p_key = index->key.Text;
                string text = configName;
                int comparison = string.CompareOrdinal(p_key, text);
                if (comparison != 0) {
                    if (comparison < 0) {
                        index = index->right;
                        result = root;
                        continue;
                    }
                } else if (index->key.Text.Length < configName.Length) {
                    index = index->right;
                    result = root;
                    continue;
                }
                result = index;
                index = index->parent;
                root = result;
            }

            return new nint(result);
        }

        private CConfigVarMapNode*[] GetConfigsInSection(string sectionName) {
            CConfigSection* section = GetSectionByName(sectionName);
            if (section == null)
                return [];

            ConfigVarMap* configMap = &section->configVarMap;
            if (configMap == null)
                return [];

            int size = configMap->size;
            if (size == 0)
                return [];

            CConfigVarMapNode*[] configs = new CConfigVarMapNode*[size];

            Stack<nint> foundNodes = new Stack<nint>();
            Stack<nint> searchStack = new Stack<nint>();

            CConfigVarMapNode* root = configMap->root;
            searchStack.Push((nint)root);
            if (root->value != null && root->isUnpopulatedNode == 0) {
                foundNodes.Push((nint)root);
            }

            CConfigVarMapNode*[] nodes = new CConfigVarMapNode*[3];
            while (searchStack.Count > 0) {
                CConfigVarMapNode* node = (CConfigVarMapNode*)searchStack.Pop();

                nodes[0] = node->left;
                nodes[1] = node->right;
                nodes[2] = node->parent;

                // Go through all the nodes to see if they are populated and not already found
                foreach (CConfigVarMapNode* n in nodes) {
                    if (n == root || n->isUnpopulatedNode != 0 || foundNodes.Contains((nint)n)) continue;

                    searchStack.Push((nint)n);
                    foundNodes.Push((nint)n);
                }
            }

            int i = 0;
            while (foundNodes.Count > 0) {
                if (i > size)
                    break; // Prevent buffer overflow

                nint node = foundNodes.Pop();
                configs[i++] = (CConfigVarMapNode*)node;
            }

            return configs;
        }

        private CConfigSection* GetSectionByName(string sectionName) {
            CConfigSection*[] sections = GetSections();
            foreach (CConfigSection* section in sections) {
                if (section == null)
                    continue;
                if (section->name.Text == sectionName) {
                    return section;
                }
            }
            return null;
        }
    }

}

namespace Forge.Game.Config.Native {
    public partial struct CConfigVar {
        public enum VarType {
            Unknown,
            Int,
            Float,
            String,
            List,
            IntArray
        }

        public VarType Type {
            get {
                return type switch {
                    0x01 => VarType.Int,
                    0x02 => VarType.IntArray,
                    0x03 => VarType.Float,
                    0x04 => VarType.String,
                    0x05 => VarType.List,
                    _ => VarType.Unknown
                };
            }
        }
    }
}
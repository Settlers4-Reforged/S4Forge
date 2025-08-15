using Forge.Native;
using Forge.Native.Helpers;

namespace Forge.Game.Config.Native
{
    public partial struct CConfigSection
    {
        [NativeInheritance(nameof(CConfigSection))]
        public wstring name;

        [NativeInheritance(nameof(CConfigSection))]
        public ConfigVarMap configVarMap;
    }
}

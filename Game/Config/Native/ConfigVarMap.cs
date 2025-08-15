using Forge.Native;
using Forge.Native.Helpers;

namespace Forge.Game.Config.Native
{
    public unsafe partial struct ConfigVarMap
    {
        [NativeInheritance(nameof(ConfigVarMap))]
        public CConfigVarMapNode* root;

        [NativeInheritance(nameof(ConfigVarMap))]
        public int size;
    }
}

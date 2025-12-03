using Forge.Native;
using Forge.Native.Helpers;

namespace Forge.Game.Config.Native
{
    // Struct Size: 0x8
    public unsafe partial struct ConfigSectionList
    {
        [NativeInheritance(nameof(ConfigSectionList))]
        public CConfigSectionListNode* start;

        [NativeInheritance(nameof(ConfigSectionList))]
        public int length;
    }
}

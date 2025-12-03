using Forge.Native;
using Forge.Native.Helpers;

namespace Forge.Game.Config.Native
{
    // Struct Size: 0xC
    public unsafe partial struct CConfigSectionListNode
    {
        [NativeInheritance(nameof(CConfigSectionListNode))]
        public CConfigSectionListNode* next;

        [NativeInheritance(nameof(CConfigSectionListNode))]
        public CConfigSectionListNode* prev;

        [NativeInheritance(nameof(CConfigSectionListNode))]
        public CConfigSection* data;
    }
}

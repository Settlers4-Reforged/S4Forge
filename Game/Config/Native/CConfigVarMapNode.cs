using Forge.Native;
using Forge.Native.Helpers;

namespace Forge.Game.Config.Native
{
    // Struct Size: 0x2C
    public unsafe partial struct CConfigVarMapNode
    {
        [NativeInheritance(nameof(CConfigVarMapNode))]
        public CConfigVarMapNode* parent;

        [NativeInheritance(nameof(CConfigVarMapNode))]
        public CConfigVarMapNode* left;

        [NativeInheritance(nameof(CConfigVarMapNode))]
        public CConfigVarMapNode* right;

        [NativeInheritance(nameof(CConfigVarMapNode))]
        [NativeTypeName("char")]
        public sbyte unk_12;

        [NativeInheritance(nameof(CConfigVarMapNode))]
        [NativeTypeName("char")]
        public sbyte isUnpopulatedNode;

        [NativeInheritance(nameof(CConfigVarMapNode))]
        public short unk_14;

        [NativeInheritance(nameof(CConfigVarMapNode))]
        public wstring key;

        [NativeInheritance(nameof(CConfigVarMapNode))]
        public CConfigVar* value;
    }
}

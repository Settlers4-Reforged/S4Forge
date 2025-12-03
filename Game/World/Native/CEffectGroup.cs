using Forge.Native;
using Forge.Native.Helpers;
using System.Runtime.InteropServices;

namespace Forge.Game.World.Native
{
    // Struct Size: 0x3C
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct CEffectGroup
    {
        [NativeInheritance(nameof(CEffectGroup))]
        public byte type;

        [NativeInheritance(nameof(CEffectGroup))]
        public byte effectId;

        [NativeInheritance(nameof(CEffectGroup))]
        public byte soundId;

        [NativeInheritance(nameof(CEffectGroup))]
        public byte field_3;

        [NativeInheritance(nameof(CEffectGroup))]
        [NativeTypeName("WORD")]
        public ushort field_4;

        [NativeInheritance(nameof(CEffectGroup))]
        public byte frameCount;

        [NativeInheritance(nameof(CEffectGroup))]
        public byte field_7;

        [NativeInheritance(nameof(CEffectGroup))]
        [NativeTypeName("char *")]
        public sbyte* startTick;

        [NativeInheritance(nameof(CEffectGroup))]
        public int field_C;

        [NativeInheritance(nameof(CEffectGroup))]
        [NativeTypeName("long long")]
        public long pos;

        [NativeInheritance(nameof(CEffectGroup))]
        public float screenOffsetX;

        [NativeInheritance(nameof(CEffectGroup))]
        public float screenOffsetY;

        [NativeInheritance(nameof(CEffectGroup))]
        [NativeTypeName("BYTE[20]")]
        public fixed byte gap_20[20];

        [NativeInheritance(nameof(CEffectGroup))]
        [NativeTypeName("int (*)(CEffectGroup *, int, unsigned int) __attribute__((thiscall))")]
        public delegate* unmanaged[Thiscall]<CEffectGroup*, int, uint, int> callback;

        [NativeInheritance(nameof(CEffectGroup))]
        [NativeTypeName("DWORD")]
        public uint field_38;
    }
}

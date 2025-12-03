using Forge.Native;
using Forge.Native.Helpers;
using System.Runtime.CompilerServices;

namespace Forge.Game.World.Native
{
    // Struct Size: 0x3C
    public unsafe partial struct CLogic : CLogic.Interface
    {
        public void** lpVtbl;

        [NativeInheritance(nameof(CLogic))]
        public int field_4;

        [NativeInheritance(nameof(CLogic))]
        public int field_8;

        [NativeInheritance(nameof(CLogic))]
        [NativeTypeName("BYTE[4]")]
        public fixed byte gap_C[4];

        [NativeInheritance(nameof(CLogic))]
        public int field_10;

        [NativeInheritance(nameof(CLogic))]
        public int field_14;

        [NativeInheritance(nameof(CLogic))]
        public int field_18;

        [NativeInheritance(nameof(CLogic))]
        [NativeTypeName("char")]
        public sbyte field_1C;

        [NativeInheritance(nameof(CLogic))]
        [NativeTypeName("BYTE[3]")]
        public fixed byte gap_1D[3];

        [NativeInheritance(nameof(CLogic))]
        public void* FutureEvents;

        [NativeInheritance(nameof(CLogic))]
        public CEffects* Effects;

        [NativeInheritance(nameof(CLogic))]
        public int field_28;

        [NativeInheritance(nameof(CLogic))]
        public int field_2C;

        [NativeInheritance(nameof(CLogic))]
        public int field_30;

        [NativeInheritance(nameof(CLogic))]
        public int field_34;

        [NativeInheritance(nameof(CLogic))]
        public int field_38;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public byte* dtor()
        {
            return ((delegate* unmanaged[Thiscall]<CLogic*, byte*>)(lpVtbl[0]))((CLogic*)Unsafe.AsPointer(ref this));
        }

        public interface Interface
        {
            [VtblIndex(0)]
            byte* dtor();
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("BYTE *() __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, byte*> dtor;
        }
    }
}

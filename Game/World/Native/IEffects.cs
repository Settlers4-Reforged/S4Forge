using Forge.Native;
using Forge.Native.Helpers;
using System.Runtime.CompilerServices;

namespace Forge.Game.World.Native
{
    // Struct Size: 0x8
    [NativeTypeName("struct IEffects : IGfxEffects, IS4ChunkObject")]
    [NativeInheritance(nameof(IGfxEffects))]
    [NativeInheritance(nameof(IS4ChunkObject))]
    public unsafe partial struct IEffects : IEffects.Interface
    {
        public void** lpVtbl_BaseIGfxEffects;

        public void** lpVtbl_BaseIS4ChunkObject;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public int sub_E3310(int a2, int a3, int a4, int a5, int a6)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, int, int, int, int, int>)(lpVtbl_BaseIGfxEffects[0]))((IEffects*)Unsafe.AsPointer(ref this), a2, a3, a4, a5, a6);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public int sub_E33B0(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, int>)(lpVtbl_BaseIGfxEffects[1]))((IEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public byte* sub_E3580()
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, byte*>)(lpVtbl_BaseIGfxEffects[2]))((IEffects*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public int sub_E3650()
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int>)(lpVtbl_BaseIGfxEffects[3]))((IEffects*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void AddEffect(int effectId, int soundId, int x, int y, int delay, int duration, int effectType)
        {
            ((delegate* unmanaged[Thiscall]<IEffects*, int, int, int, int, int, int, int, void>)(lpVtbl_BaseIGfxEffects[4]))((IEffects*)Unsafe.AsPointer(ref this), effectId, soundId, x, y, delay, duration, effectType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public int sub_E3C80(int param0, [NativeTypeName("char")] sbyte param1, int param2, int param3, int param4, int param5)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, sbyte, int, int, int, int, int>)(lpVtbl_BaseIGfxEffects[5]))((IEffects*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4, param5);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public int sub_E3B20(int param0, int param1, int param2, int param3, int param4, int param5)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, int, int, int, int, int, int>)(lpVtbl_BaseIGfxEffects[6]))((IEffects*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4, param5);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public int sub_E3B90(int param0, int param1, int param2)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, int, int, int>)(lpVtbl_BaseIGfxEffects[7]))((IEffects*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public int sub_E3C10([NativeTypeName("unsigned int")] uint param0, [NativeTypeName("char")] sbyte param1, [NativeTypeName("long long")] long param2, [NativeTypeName("char")] sbyte param3, int param4)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, uint, sbyte, long, sbyte, int, int>)(lpVtbl_BaseIGfxEffects[8]))((IEffects*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("char")]
        public sbyte sub_E3D00(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, sbyte>)(lpVtbl_BaseIGfxEffects[9]))((IEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public int sub_E3D60([NativeTypeName("unsigned int")] uint param0, float param1, float param2)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, uint, float, float, int>)(lpVtbl_BaseIGfxEffects[10]))((IEffects*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public int sub_E3DC0(int param0, [NativeTypeName("unsigned int")] uint param1)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, uint, int>)(lpVtbl_BaseIGfxEffects[11]))((IEffects*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public int sub_E3E50(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, int>)(lpVtbl_BaseIGfxEffects[12]))((IEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("DWORD *")]
        public uint* sub_E3E70(int param0, [NativeTypeName("DWORD *")] uint* param1, [NativeTypeName("DWORD *")] uint* param2, [NativeTypeName("DWORD *")] uint* param3, [NativeTypeName("DWORD *")] uint* param4)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, uint*, uint*, uint*, uint*, uint*>)(lpVtbl_BaseIGfxEffects[13]))((IEffects*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public int sub_E3F20(int param0, int param1)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, int, int>)(lpVtbl_BaseIGfxEffects[14]))((IEffects*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public int sub_E3F70(int param0, float param1, [NativeTypeName("unsigned int")] uint param2, float param3)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, float, uint, float, int>)(lpVtbl_BaseIGfxEffects[15]))((IEffects*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public int sub_E3FC0(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, int>)(lpVtbl_BaseIGfxEffects[16]))((IEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public int sub_E4000(int param0, int param1)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, int, int>)(lpVtbl_BaseIGfxEffects[17]))((IEffects*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public int sub_E4070(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, int>)(lpVtbl_BaseIGfxEffects[18]))((IEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public int sub_E4050(int param0, int param1)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, int, int>)(lpVtbl_BaseIGfxEffects[19]))((IEffects*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public int sub_E4090([NativeTypeName("char")] sbyte param0, int param1, [NativeTypeName("char")] sbyte param2)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, sbyte, int, sbyte, int>)(lpVtbl_BaseIGfxEffects[20]))((IEffects*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public int sub_E4110(int param0, int param1, int param2)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, int, int, int>)(lpVtbl_BaseIGfxEffects[21]))((IEffects*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("char")]
        public sbyte sub_E4160(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, sbyte>)(lpVtbl_BaseIGfxEffects[22]))((IEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("char")]
        public sbyte sub_E41E0(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, sbyte>)(lpVtbl_BaseIGfxEffects[23]))((IEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public int sub_E4230()
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int>)(lpVtbl_BaseIGfxEffects[24]))((IEffects*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public int sub_E3810(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, int, int>)(lpVtbl_BaseIGfxEffects[25]))((IEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public int Unknown_1(void* a2)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, void*, int>)(lpVtbl_BaseIS4ChunkObject[0]))((IEffects*)Unsafe.AsPointer(ref this), a2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public int Unknown_2(void* a2)
        {
            return ((delegate* unmanaged[Thiscall]<IEffects*, void*, int>)(lpVtbl_BaseIS4ChunkObject[1]))((IEffects*)Unsafe.AsPointer(ref this), a2);
        }

        public interface Interface : IGfxEffects.Interface, IS4ChunkObject.Interface
        {
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("int (int, int, int, int, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int, int, int, int, int> sub_E3310;

            [NativeTypeName("int (int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int> sub_E33B0;

            [NativeTypeName("BYTE *() __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, byte*> sub_E3580;

            [NativeTypeName("int () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int> sub_E3650;

            [NativeTypeName("void (int, int, int, int, int, int, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int, int, int, int, int, int, void> AddEffect;

            [NativeTypeName("int (int, char, int, int, int, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, sbyte, int, int, int, int, int> sub_E3C80;

            [NativeTypeName("int (int, int, int, int, int, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int, int, int, int, int, int> sub_E3B20;

            [NativeTypeName("int (int, int, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int, int, int> sub_E3B90;

            [NativeTypeName("int (unsigned int, char, long long, char, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, sbyte, long, sbyte, int, int> sub_E3C10;

            [NativeTypeName("char (int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, sbyte> sub_E3D00;

            [NativeTypeName("int (unsigned int, float, float) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, float, float, int> sub_E3D60;

            [NativeTypeName("int (int, unsigned int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, uint, int> sub_E3DC0;

            [NativeTypeName("int (int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int> sub_E3E50;

            [NativeTypeName("DWORD *(int, DWORD *, DWORD *, DWORD *, DWORD *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, uint*, uint*, uint*, uint*, uint*> sub_E3E70;

            [NativeTypeName("int (int, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int, int> sub_E3F20;

            [NativeTypeName("int (int, float, unsigned int, float) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, float, uint, float, int> sub_E3F70;

            [NativeTypeName("int (int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int> sub_E3FC0;

            [NativeTypeName("int (int, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int, int> sub_E4000;

            [NativeTypeName("int (int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int> sub_E4070;

            [NativeTypeName("int (int, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int, int> sub_E4050;

            [NativeTypeName("int (char, int, char) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte, int, sbyte, int> sub_E4090;

            [NativeTypeName("int (int, int, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int, int, int> sub_E4110;

            [NativeTypeName("char (int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, sbyte> sub_E4160;

            [NativeTypeName("char (int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, sbyte> sub_E41E0;

            [NativeTypeName("int () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int> sub_E4230;

            [NativeTypeName("int (int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int> sub_E3810;

            [NativeTypeName("int (void *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*, int> Unknown_1;

            [NativeTypeName("int (void *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*, int> Unknown_2;
        }
    }
}

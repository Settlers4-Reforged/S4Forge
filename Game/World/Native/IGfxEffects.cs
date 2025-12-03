using Forge.Native;
using Forge.Native.Helpers;
using System.Runtime.CompilerServices;

namespace Forge.Game.World.Native
{
    // Struct Size: 0x4
    public unsafe partial struct IGfxEffects : IGfxEffects.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public int sub_E3310(int a2, int a3, int a4, int a5, int a6)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, int, int, int, int, int>)(lpVtbl[0]))((IGfxEffects*)Unsafe.AsPointer(ref this), a2, a3, a4, a5, a6);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public int sub_E33B0(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, int>)(lpVtbl[1]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public byte* sub_E3580()
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, byte*>)(lpVtbl[2]))((IGfxEffects*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public int sub_E3650()
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int>)(lpVtbl[3]))((IGfxEffects*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void AddEffect(int effectId, int soundId, int x, int y, int delay, int duration, int effectType)
        {
            ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, int, int, int, int, int, int, void>)(lpVtbl[4]))((IGfxEffects*)Unsafe.AsPointer(ref this), effectId, soundId, x, y, delay, duration, effectType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public int sub_E3C80(int param0, [NativeTypeName("char")] sbyte param1, int param2, int param3, int param4, int param5)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, sbyte, int, int, int, int, int>)(lpVtbl[5]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4, param5);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public int sub_E3B20(int param0, int param1, int param2, int param3, int param4, int param5)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, int, int, int, int, int, int>)(lpVtbl[6]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4, param5);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public int sub_E3B90(int param0, int param1, int param2)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, int, int, int>)(lpVtbl[7]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public int sub_E3C10([NativeTypeName("unsigned int")] uint param0, [NativeTypeName("char")] sbyte param1, [NativeTypeName("long long")] long param2, [NativeTypeName("char")] sbyte param3, int param4)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, uint, sbyte, long, sbyte, int, int>)(lpVtbl[8]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("char")]
        public sbyte sub_E3D00(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, sbyte>)(lpVtbl[9]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public int sub_E3D60([NativeTypeName("unsigned int")] uint param0, float param1, float param2)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, uint, float, float, int>)(lpVtbl[10]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public int sub_E3DC0(int param0, [NativeTypeName("unsigned int")] uint param1)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, uint, int>)(lpVtbl[11]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public int sub_E3E50(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, int>)(lpVtbl[12]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("DWORD *")]
        public uint* sub_E3E70(int param0, [NativeTypeName("DWORD *")] uint* param1, [NativeTypeName("DWORD *")] uint* param2, [NativeTypeName("DWORD *")] uint* param3, [NativeTypeName("DWORD *")] uint* param4)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, uint*, uint*, uint*, uint*, uint*>)(lpVtbl[13]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public int sub_E3F20(int param0, int param1)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, int, int>)(lpVtbl[14]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public int sub_E3F70(int param0, float param1, [NativeTypeName("unsigned int")] uint param2, float param3)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, float, uint, float, int>)(lpVtbl[15]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public int sub_E3FC0(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, int>)(lpVtbl[16]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public int sub_E4000(int param0, int param1)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, int, int>)(lpVtbl[17]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public int sub_E4070(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, int>)(lpVtbl[18]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public int sub_E4050(int param0, int param1)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, int, int>)(lpVtbl[19]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public int sub_E4090([NativeTypeName("char")] sbyte param0, int param1, [NativeTypeName("char")] sbyte param2)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, sbyte, int, sbyte, int>)(lpVtbl[20]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public int sub_E4110(int param0, int param1, int param2)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, int, int, int>)(lpVtbl[21]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("char")]
        public sbyte sub_E4160(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, sbyte>)(lpVtbl[22]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("char")]
        public sbyte sub_E41E0(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, sbyte>)(lpVtbl[23]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public int sub_E4230()
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int>)(lpVtbl[24]))((IGfxEffects*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public int sub_E3810(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<IGfxEffects*, int, int>)(lpVtbl[25]))((IGfxEffects*)Unsafe.AsPointer(ref this), param0);
        }

        public interface Interface
        {
            [VtblIndex(0)]
            int sub_E3310(int a2, int a3, int a4, int a5, int a6);

            [VtblIndex(1)]
            int sub_E33B0(int param0);

            [VtblIndex(2)]
            byte* sub_E3580();

            [VtblIndex(3)]
            int sub_E3650();

            [VtblIndex(4)]
            void AddEffect(int effectId, int soundId, int x, int y, int delay, int duration, int effectType);

            [VtblIndex(5)]
            int sub_E3C80(int param0, [NativeTypeName("char")] sbyte param1, int param2, int param3, int param4, int param5);

            [VtblIndex(6)]
            int sub_E3B20(int param0, int param1, int param2, int param3, int param4, int param5);

            [VtblIndex(7)]
            int sub_E3B90(int param0, int param1, int param2);

            [VtblIndex(8)]
            int sub_E3C10([NativeTypeName("unsigned int")] uint param0, [NativeTypeName("char")] sbyte param1, [NativeTypeName("long long")] long param2, [NativeTypeName("char")] sbyte param3, int param4);

            [VtblIndex(9)]
            [return: NativeTypeName("char")]
            sbyte sub_E3D00(int param0);

            [VtblIndex(10)]
            int sub_E3D60([NativeTypeName("unsigned int")] uint param0, float param1, float param2);

            [VtblIndex(11)]
            int sub_E3DC0(int param0, [NativeTypeName("unsigned int")] uint param1);

            [VtblIndex(12)]
            int sub_E3E50(int param0);

            [VtblIndex(13)]
            [return: NativeTypeName("DWORD *")]
            uint* sub_E3E70(int param0, [NativeTypeName("DWORD *")] uint* param1, [NativeTypeName("DWORD *")] uint* param2, [NativeTypeName("DWORD *")] uint* param3, [NativeTypeName("DWORD *")] uint* param4);

            [VtblIndex(14)]
            int sub_E3F20(int param0, int param1);

            [VtblIndex(15)]
            int sub_E3F70(int param0, float param1, [NativeTypeName("unsigned int")] uint param2, float param3);

            [VtblIndex(16)]
            int sub_E3FC0(int param0);

            [VtblIndex(17)]
            int sub_E4000(int param0, int param1);

            [VtblIndex(18)]
            int sub_E4070(int param0);

            [VtblIndex(19)]
            int sub_E4050(int param0, int param1);

            [VtblIndex(20)]
            int sub_E4090([NativeTypeName("char")] sbyte param0, int param1, [NativeTypeName("char")] sbyte param2);

            [VtblIndex(21)]
            int sub_E4110(int param0, int param1, int param2);

            [VtblIndex(22)]
            [return: NativeTypeName("char")]
            sbyte sub_E4160(int param0);

            [VtblIndex(23)]
            [return: NativeTypeName("char")]
            sbyte sub_E41E0(int param0);

            [VtblIndex(24)]
            int sub_E4230();

            [VtblIndex(25)]
            int sub_E3810(int param0);
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
        }
    }
}

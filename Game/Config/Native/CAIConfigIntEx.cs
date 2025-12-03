using Forge.Native;
using Forge.Native.Helpers;
using System.Runtime.CompilerServices;

namespace Forge.Game.Config.Native
{
    // Struct Size: 0x14
    [NativeTypeName("struct CAIConfigIntEx : CStaticConfigVar")]
    [NativeInheritance(nameof(CStaticConfigVar))]
    public unsafe partial struct CAIConfigIntEx : CAIConfigIntEx.Interface
    {
        public void** lpVtbl;

        [NativeInheritance(nameof(CConfigVar))]
        [NativeTypeName("char")]
        public sbyte field_4;

        [NativeInheritance(nameof(CConfigVar))]
        [NativeTypeName("char")]
        public sbyte type;

        [NativeInheritance(nameof(CConfigVar))]
        [NativeTypeName("char")]
        public sbyte itemCount;

        [NativeInheritance(nameof(CConfigVar))]
        [NativeTypeName("char")]
        public sbyte field_7;

        [NativeInheritance(nameof(CAIConfigIntEx))]
        [NativeTypeName("int[3]")]
        public fixed int value[3];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public int GetInt()
        {
            return ((delegate* unmanaged[Thiscall]<CAIConfigIntEx*, int>)(lpVtbl[0]))((CAIConfigIntEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public double GetDouble()
        {
            return ((delegate* unmanaged[Thiscall]<CAIConfigIntEx*, double>)(lpVtbl[1]))((CAIConfigIntEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public wstring* GetString(wstring* @out)
        {
            return ((delegate* unmanaged[Thiscall]<CAIConfigIntEx*, wstring*, wstring*>)(lpVtbl[2]))((CAIConfigIntEx*)Unsafe.AsPointer(ref this), @out);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public int* GetList()
        {
            return ((delegate* unmanaged[Thiscall]<CAIConfigIntEx*, int*>)(lpVtbl[3]))((CAIConfigIntEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public int* GetArray()
        {
            return ((delegate* unmanaged[Thiscall]<CAIConfigIntEx*, int*>)(lpVtbl[4]))((CAIConfigIntEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public wstring* SetWStringValue(wstring* value)
        {
            return ((delegate* unmanaged[Thiscall]<CAIConfigIntEx*, wstring*, wstring*>)(lpVtbl[5]))((CAIConfigIntEx*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public wstring* SetCStringValue([NativeTypeName("const char *")] sbyte* value)
        {
            return ((delegate* unmanaged[Thiscall]<CAIConfigIntEx*, sbyte*, wstring*>)(lpVtbl[6]))((CAIConfigIntEx*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public int SetDoubleValue(float value)
        {
            return ((delegate* unmanaged[Thiscall]<CAIConfigIntEx*, float, int>)(lpVtbl[7]))((CAIConfigIntEx*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public int SetIntValue(int value)
        {
            return ((delegate* unmanaged[Thiscall]<CAIConfigIntEx*, int, int>)(lpVtbl[8]))((CAIConfigIntEx*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("DWORD *")]
        public uint* DestroyConfigVar([NativeTypeName("char")] sbyte deleteMemory)
        {
            return ((delegate* unmanaged[Thiscall]<CAIConfigIntEx*, sbyte, uint*>)(lpVtbl[9]))((CAIConfigIntEx*)Unsafe.AsPointer(ref this), deleteMemory);
        }

        public interface Interface : CStaticConfigVar.Interface
        {
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("int () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int> GetInt;

            [NativeTypeName("double () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, double> GetDouble;

            [NativeTypeName("wstring *(wstring *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, wstring*, wstring*> GetString;

            [NativeTypeName("int *() __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int*> GetList;

            [NativeTypeName("int *() __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int*> GetArray;

            [NativeTypeName("wstring *(wstring *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, wstring*, wstring*> SetWStringValue;

            [NativeTypeName("wstring *(const char *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte*, wstring*> SetCStringValue;

            [NativeTypeName("int (float) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, float, int> SetDoubleValue;

            [NativeTypeName("int (int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int> SetIntValue;

            [NativeTypeName("DWORD *(char) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte, uint*> DestroyConfigVar;
        }
    }
}

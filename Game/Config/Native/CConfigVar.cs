using Forge.Native;
using Forge.Native.Helpers;
using System.Runtime.CompilerServices;

namespace Forge.Game.Config.Native
{
    // Struct Size: 0x8
    public unsafe partial struct CConfigVar : CConfigVar.Interface
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public int GetInt()
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, int>)(lpVtbl[0]))((CConfigVar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public double GetDouble()
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, double>)(lpVtbl[1]))((CConfigVar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public wstring* GetString(wstring* @out)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, wstring*, wstring*>)(lpVtbl[2]))((CConfigVar*)Unsafe.AsPointer(ref this), @out);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public int* GetList()
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, int*>)(lpVtbl[3]))((CConfigVar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public int* GetArray()
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, int*>)(lpVtbl[4]))((CConfigVar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public wstring* SetWStringValue(wstring* value)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, wstring*, wstring*>)(lpVtbl[5]))((CConfigVar*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public wstring* SetCStringValue([NativeTypeName("const char *")] sbyte* value)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, sbyte*, wstring*>)(lpVtbl[6]))((CConfigVar*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public int SetDoubleValue(float value)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, float, int>)(lpVtbl[7]))((CConfigVar*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public int SetIntValue(int value)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, int, int>)(lpVtbl[8]))((CConfigVar*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("DWORD *")]
        public uint* DestroyConfigVar([NativeTypeName("char")] sbyte deleteMemory)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, sbyte, uint*>)(lpVtbl[9]))((CConfigVar*)Unsafe.AsPointer(ref this), deleteMemory);
        }

        public interface Interface
        {
            [VtblIndex(0)]
            int GetInt();

            [VtblIndex(1)]
            double GetDouble();

            [VtblIndex(2)]
            wstring* GetString(wstring* @out);

            [VtblIndex(3)]
            int* GetList();

            [VtblIndex(4)]
            int* GetArray();

            [VtblIndex(5)]
            wstring* SetWStringValue(wstring* value);

            [VtblIndex(6)]
            wstring* SetCStringValue([NativeTypeName("const char *")] sbyte* value);

            [VtblIndex(7)]
            int SetDoubleValue(float value);

            [VtblIndex(8)]
            int SetIntValue(int value);

            [VtblIndex(9)]
            [return: NativeTypeName("DWORD *")]
            uint* DestroyConfigVar([NativeTypeName("char")] sbyte deleteMemory);
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

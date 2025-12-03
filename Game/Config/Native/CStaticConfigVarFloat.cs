using Forge.Native;
using Forge.Native.Helpers;
using System.Runtime.CompilerServices;

namespace Forge.Game.Config.Native
{
    // Struct Size: 0xC
    [NativeTypeName("struct CStaticConfigVarFloat : CStaticConfigVar")]
    [NativeInheritance(nameof(CStaticConfigVar))]
    public unsafe partial struct CStaticConfigVarFloat : CStaticConfigVarFloat.Interface
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

        [NativeInheritance(nameof(CStaticConfigVarFloat))]
        public float value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public int GetInt()
        {
            return ((delegate* unmanaged[Thiscall]<CStaticConfigVarFloat*, int>)(lpVtbl[0]))((CStaticConfigVarFloat*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public double GetDouble()
        {
            return ((delegate* unmanaged[Thiscall]<CStaticConfigVarFloat*, double>)(lpVtbl[1]))((CStaticConfigVarFloat*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public wstring* GetString(wstring* @out)
        {
            return ((delegate* unmanaged[Thiscall]<CStaticConfigVarFloat*, wstring*, wstring*>)(lpVtbl[2]))((CStaticConfigVarFloat*)Unsafe.AsPointer(ref this), @out);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public int* GetList()
        {
            return ((delegate* unmanaged[Thiscall]<CStaticConfigVarFloat*, int*>)(lpVtbl[3]))((CStaticConfigVarFloat*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public int* GetArray()
        {
            return ((delegate* unmanaged[Thiscall]<CStaticConfigVarFloat*, int*>)(lpVtbl[4]))((CStaticConfigVarFloat*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public wstring* SetWStringValue(wstring* value)
        {
            return ((delegate* unmanaged[Thiscall]<CStaticConfigVarFloat*, wstring*, wstring*>)(lpVtbl[5]))((CStaticConfigVarFloat*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public wstring* SetCStringValue([NativeTypeName("const char *")] sbyte* value)
        {
            return ((delegate* unmanaged[Thiscall]<CStaticConfigVarFloat*, sbyte*, wstring*>)(lpVtbl[6]))((CStaticConfigVarFloat*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public int SetDoubleValue(float value)
        {
            return ((delegate* unmanaged[Thiscall]<CStaticConfigVarFloat*, float, int>)(lpVtbl[7]))((CStaticConfigVarFloat*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public int SetIntValue(int value)
        {
            return ((delegate* unmanaged[Thiscall]<CStaticConfigVarFloat*, int, int>)(lpVtbl[8]))((CStaticConfigVarFloat*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("DWORD *")]
        public uint* DestroyConfigVar([NativeTypeName("char")] sbyte deleteMemory)
        {
            return ((delegate* unmanaged[Thiscall]<CStaticConfigVarFloat*, sbyte, uint*>)(lpVtbl[9]))((CStaticConfigVarFloat*)Unsafe.AsPointer(ref this), deleteMemory);
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

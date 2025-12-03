using Forge.Native;
using Forge.Native.Helpers;
using System.Runtime.CompilerServices;

namespace Forge.Game.World.Native
{
    // Struct Size: 0x4
    public unsafe partial struct CBBObject : CBBObject.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("DWORD *")]
        public uint* dtor([NativeTypeName("char")] sbyte a2)
        {
            return ((delegate* unmanaged[Thiscall]<CBBObject*, sbyte, uint*>)(lpVtbl[0]))((CBBObject*)Unsafe.AsPointer(ref this), a2);
        }

        public interface Interface
        {
            [VtblIndex(0)]
            [return: NativeTypeName("DWORD *")]
            uint* dtor([NativeTypeName("char")] sbyte a2);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("DWORD *(char) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte, uint*> dtor;
        }
    }
}

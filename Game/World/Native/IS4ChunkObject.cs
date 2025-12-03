using Forge.Native;
using Forge.Native.Helpers;
using System.Runtime.CompilerServices;

namespace Forge.Game.World.Native
{
    // Struct Size: 0x4
    public unsafe partial struct IS4ChunkObject : IS4ChunkObject.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public int Unknown_1(void* a2)
        {
            return ((delegate* unmanaged[Thiscall]<IS4ChunkObject*, void*, int>)(lpVtbl[0]))((IS4ChunkObject*)Unsafe.AsPointer(ref this), a2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public int Unknown_2(void* a2)
        {
            return ((delegate* unmanaged[Thiscall]<IS4ChunkObject*, void*, int>)(lpVtbl[1]))((IS4ChunkObject*)Unsafe.AsPointer(ref this), a2);
        }

        public interface Interface
        {
            [VtblIndex(0)]
            int Unknown_1(void* a2);

            [VtblIndex(1)]
            int Unknown_2(void* a2);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("int (void *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*, int> Unknown_1;

            [NativeTypeName("int (void *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*, int> Unknown_2;
        }
    }
}

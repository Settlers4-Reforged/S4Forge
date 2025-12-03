using Forge.Native;
using Forge.Native.Helpers;
using System.Runtime.InteropServices;

namespace Forge.Native
{
    // Struct Size: 0x18
    public partial struct wstring
    {
        [NativeInheritance(nameof(wstring))]
        [NativeTypeName("__AnonymousRecord_wstring_L3_C5")]
        public wstring._storage_e__Union storage;

        [NativeInheritance(nameof(wstring))]
        public int size;

        [NativeInheritance(nameof(wstring))]
        public int capacity;

        // Struct Size: 0x10
        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _storage_e__Union
        {
            [FieldOffset(0)]
            public short* text;

            [FieldOffset(0)]
            [NativeTypeName("short[8]")]
            public fixed short buffer[8];
        }
    }
}

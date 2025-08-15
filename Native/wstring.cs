using Forge.Native;
using Forge.Native.Helpers;

namespace Forge.Native
{
    public unsafe partial struct wstring
    {
        [NativeInheritance(nameof(wstring))]
        [NativeTypeName("wchar_t *")]
        public ushort* text;

        [NativeInheritance(nameof(wstring))]
        public int size;

        [NativeInheritance(nameof(wstring))]
        public int capacity;

        [NativeInheritance(nameof(wstring))]
        public int field_0C;

        [NativeInheritance(nameof(wstring))]
        public int capacity_;

        [NativeInheritance(nameof(wstring))]
        public int field_14;
    }
}

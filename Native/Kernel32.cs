using System;
using System.Runtime.InteropServices;

namespace Forge.Native {
    public static partial class Kernel32 {
        [LibraryImport("kernel32", SetLastError = true, StringMarshalling = StringMarshalling.Utf8)]
        public static partial IntPtr GetProcAddress(IntPtr/*HMODULE*/ hModule, string procName);

        [LibraryImport("kernel32", SetLastError = true, StringMarshalling = StringMarshalling.Utf8)]
        public static partial IntPtr/*HMODULE*/ LoadLibrary(string lpFileName);

        [LibraryImport("kernel32.dll")]
        public static partial int GetModuleHandleA(IntPtr name);

        [LibraryImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

        public const uint PAGE_EXECUTE_READWRITE = 0x40;
    }
}

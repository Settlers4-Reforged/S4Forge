using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Forge.Native.MemoryPatcher {
    /// <summary>
    /// Patches a single address in the current process with NOPs (0x90) for a specified length and can revert.
    /// Usage: using var p = new NopPatch(address, length); // applies immediately, reverts on Dispose or call Revert()
    /// </summary>
    public unsafe sealed class NopPatch : IPatch {
        private readonly IntPtr address;
        private readonly int length;
        private readonly byte[] original;
        private bool applied;
        private bool disposed;

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

        private const uint PAGE_EXECUTE_READWRITE = 0x40;

        private const byte NOP_OPCODE = 0x90;

        /// <summary>
        /// Creates and applies a NOP patch at the given address.
        /// </summary>
        /// <param name="address">Target address to patch.</param>
        /// <param name="length">Number of bytes to overwrite with NOPs.</param>
        public NopPatch(IntPtr address, int length) {
            if (length <= 0)
                throw new ArgumentOutOfRangeException(nameof(length), "Length must be greater than zero.");

            this.address = address;
            this.length = length;

            // Read original bytes
            original = new byte[this.length];
            Marshal.Copy(this.address, original, 0, this.length);
        }

        /// <summary>
        /// Applies the NOP patch if not already applied.
        /// </summary>
        public void Apply() {
            if (applied) return;


            // Prepare small stack buffer of NOPs when length is small for better locality
            // Fallback to heap if larger.
            byte[]? nops = (length <= 64) ? null : new byte[length];

            uint oldProtect;
            if (!VirtualProtect(address, (UIntPtr)length, PAGE_EXECUTE_READWRITE, out oldProtect))
                throw new Win32Exception(Marshal.GetLastWin32Error(), "VirtualProtect failed to set PAGE_EXECUTE_READWRITE.");

            try {
                if (nops == null) {
                    byte* stackBuf = stackalloc byte[length];
                    for (int i = 0; i < length; i++) stackBuf[i] = NOP_OPCODE;
                    Buffer.MemoryCopy(stackBuf, (void*)address, length, length);
                } else {
                    // heap buffer
                    for (int i = 0; i < length; i++) nops![i] = NOP_OPCODE;
                    fixed (byte* nopsPtr = nops) {
                        Buffer.MemoryCopy(nopsPtr, (void*)address, length, length);
                    }
                }


                applied = true;
            } catch (Exception ex) {
                // try to restore previous protection
                VirtualProtect(address, (UIntPtr)length, oldProtect, out _);
                throw new Win32Exception("Failed writing NOPs to target memory.", ex);
            }


            if (!VirtualProtect(address, (UIntPtr)length, oldProtect, out _)) {
                throw new Win32Exception(Marshal.GetLastWin32Error(), "VirtualProtect failed to restore original protection after applying patch.");
            }
        }

        /// <summary>
        /// Reverts the patched region back to the original bytes. Safe to call multiple times.
        /// </summary>
        public void Revert() {
            if (!applied) return;

            if (!VirtualProtect(address, (UIntPtr)length, PAGE_EXECUTE_READWRITE, out var oldProtect))
                throw new Win32Exception(Marshal.GetLastWin32Error(), "VirtualProtect failed to set PAGE_EXECUTE_READWRITE for revert.");

            try {
                Marshal.Copy(original, 0, address, length);
                applied = false;
            } catch (Exception ex) {
                // Attempt to restore protection before rethrowing
                VirtualProtect(address, (UIntPtr)length, oldProtect, out _);
                throw new Win32Exception("Failed writing original bytes back to memory during revert.", ex);
            }

            if (!VirtualProtect(address, (UIntPtr)length, oldProtect, out _)) {
                throw new Win32Exception(Marshal.GetLastWin32Error(), "VirtualProtect failed to restore original protection after revert.");
            }
        }

        public void AssertExpectedBytes(byte[] expectation) {
            if (expectation.Length != length)
                throw new ArgumentException("Expectation length does not match patch length.", nameof(expectation));

            for (int i = 0; i < length; i++) {
                if (original[i] != expectation[i]) {
                    throw new InvalidOperationException($"Byte mismatch at offset {i}: expected 0x{expectation[i]:X2}, found 0x{original[i]:X2}");
                }
            }
        }

        /// <summary>
        /// Returns true if the patch is currently applied.
        /// </summary>
        public bool IsApplied => applied;
    }
}

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Forge.Native.MemoryPatcher {
    /// <summary>
    /// Unsafe, single-address JMP patcher for the current process.
    /// Writes a 5-byte x86 near JMP (E9 <rel32>) to the target address and optionally pads the remaining bytes with NOPs.
    /// Usage: using var p = new JmpPatchUnsafe(addressToPatch, jumpTarget, length);
    /// The 'length' must be at least 5. Any extra bytes after the 5-byte JMP will be filled with 0x90 NOPs.
    /// </summary>
    public sealed unsafe class JmpPatch : IPatch {
        private readonly IntPtr address;
        private readonly IntPtr target;
        private readonly int length;
        private readonly byte[] original;
        private bool applied;

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

        private const uint PAGE_EXECUTE_READWRITE = 0x40;

        /// <summary>
        /// Creates and applies a JMP patch at the provided address.
        /// </summary>
        /// <param name="address">Address to overwrite with the JMP instruction.</param>
        /// <param name="target">Absolute target address the JMP should jump to.</param>
        /// <param name="nops">Total number of nops to append</param>
        /// <param name="method">The opcode to use for the jump. Default is 0xE9 (JMP). Use 0xE8 for CALL.</param>
        public JmpPatch(IntPtr address, IntPtr target, int nops = 0, byte method = 0xE9) {
            this.address = address;
            this.target = target;
            this.length = 5 + nops;
            this.original = new byte[this.length];

            // Save original bytes
            fixed (byte* origPtr = original) {
                Buffer.MemoryCopy((void*)this.address, origPtr, this.length, this.length);
            }
        }

        /// <summary>
        /// Apply the JMP patch. Safe to call multiple times (will no-op if already applied).
        /// </summary>
        public void Apply() {
            if (applied) return;

            // Calculate relative offset for 5-byte E9 rel32: rel = target - (address + 5)
            long relLong = (long)target - ((long)address + 5);
            if (relLong < int.MinValue || relLong > int.MaxValue) {
                // On x64 this means the target is out of range for a 32-bit relative jump.
                throw new NotSupportedException("Target out of range for a 5-byte relative CALL. Please write an issue showing that you require absolute call patching.");
            }

            int rel32 = (int)relLong;

            uint oldProtect;
            if (!VirtualProtect(address, (UIntPtr)length, PAGE_EXECUTE_READWRITE, out oldProtect))
                throw new Win32Exception(Marshal.GetLastWin32Error(), "VirtualProtect failed to set PAGE_EXECUTE_READWRITE.");

            try {
                // Build the patch in a temporary buffer: [0] = 0xE9, [1..4] = rel32 little-endian, rest = 0x90
                // Use stackalloc for small sizes
                byte* buf = stackalloc byte[length];

                buf[0] = 0xE9; // opcode
                // write rel32 little-endian
                buf[1] = (byte)(rel32 & 0xFF);
                buf[2] = (byte)((rel32 >> 8) & 0xFF);
                buf[3] = (byte)((rel32 >> 16) & 0xFF);
                buf[4] = (byte)((rel32 >> 24) & 0xFF);

                for (int i = 5; i < length; i++) buf[i] = 0x90; // pad with NOPs

                Buffer.MemoryCopy(buf, (void*)address, length, length);
                applied = true;
            } catch (Exception ex) {
                VirtualProtect(address, (UIntPtr)length, oldProtect, out _);
                throw new Win32Exception("Failed writing JMP patch to target memory.", ex);
            }

            if (!VirtualProtect(address, (UIntPtr)length, oldProtect, out _)) {
                throw new Win32Exception(Marshal.GetLastWin32Error(), "VirtualProtect failed to restore original protection after applying patch.");
            }
        }

        /// <summary>
        /// Reverts the patch by restoring the original bytes. Safe to call multiple times.
        /// </summary>
        public void Revert() {
            if (!applied) return;

            uint oldProtect;
            if (!VirtualProtect(address, (UIntPtr)length, PAGE_EXECUTE_READWRITE, out oldProtect))
                throw new Win32Exception(Marshal.GetLastWin32Error(), "VirtualProtect failed to set PAGE_EXECUTE_READWRITE for revert.");

            try {
                fixed (byte* origPtr = original) {
                    Buffer.MemoryCopy(origPtr, (void*)address, length, length);
                }

                applied = false;
            } catch (Exception ex) {
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
        /// True if the JMP patch is currently applied.
        /// </summary>
        public bool IsApplied => applied;
    }
}
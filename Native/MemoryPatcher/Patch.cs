using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Native.MemoryPatcher {

    /// <summary>
    /// Generic single-address patcher: writes an arbitrary byte array to a target address in the current process
    /// and can revert to the saved original bytes. Designed for performance using unsafe memory copies.
    /// </summary>
    /// <example>
    /// using var p = new PatchUnsafe(address, new byte[] { 0x90, 0x90 }); // applies immediately
    /// // or
    /// var p = new PatchUnsafe(address, data, applyImmediately: false);
    /// p.Apply();
    /// p.Revert();
    /// </example>
    public sealed unsafe class Patch : IPatch {
        private readonly IntPtr address;
        private readonly byte[] data;
        private readonly int length;
        private readonly byte[] original;
        private bool applied;

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

        private const uint PAGE_EXECUTE_READWRITE = 0x40;

        /// <summary>
        /// Create a patch that will overwrite the target address with the provided data.
        /// By default the patch is applied immediately. Set applyImmediately to false to defer Apply().
        /// </summary>
        /// <param name="address">Address to overwrite in the current process.</param>
        /// <param name="data">Byte array to write to the address.</param>
        /// <param name="applyImmediately">If true (default) apply the patch in the constructor.</param>
        public Patch(IntPtr address, byte[] data) {
            ArgumentNullException.ThrowIfNull(data);
            ArgumentOutOfRangeException.ThrowIfZero(data.Length, nameof(data));

            this.address = address;
            this.data = new byte[data.Length];
            Array.Copy(data, this.data, data.Length);
            length = this.data.Length;
            original = new byte[length];

            // Save original bytes
            fixed (byte* origPtr = original) {
                Buffer.MemoryCopy((void*)this.address, origPtr, length, length);
            }
        }

        /// <summary>
        /// Writes the provided data to the target address. No-op if already applied.
        /// </summary>
        public void Apply() {
            if (applied) return;

            uint oldProtect;
            if (!VirtualProtect(address, (UIntPtr)length, PAGE_EXECUTE_READWRITE, out oldProtect))
                throw new Win32Exception(Marshal.GetLastWin32Error(), "VirtualProtect failed to set PAGE_EXECUTE_READWRITE.");

            try {
                fixed (byte* dataPtr = data) {
                    Buffer.MemoryCopy(dataPtr, (void*)address, length, length);
                }

                applied = true;
            } catch (Exception ex) {
                // attempt to restore protection before throwing
                VirtualProtect(address, (UIntPtr)length, oldProtect, out _);
                throw new Win32Exception("Failed writing patch bytes to memory.", ex);
            }

            if (!VirtualProtect(address, (UIntPtr)length, oldProtect, out _)) {
                throw new Win32Exception(Marshal.GetLastWin32Error(), "VirtualProtect failed to restore original protection after applying patch.");
            }
        }

        /// <summary>
        /// Restores the original bytes saved at construction. Safe to call multiple times.
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

        /// <summary>
        /// True if the patch is currently applied.
        /// </summary>
        public bool IsApplied => applied;

        public void AssertExpectedBytes(byte[] expectation) {
            if (expectation.Length != length)
                throw new ArgumentException("Expectation length does not match patch length.", nameof(expectation));

            for (int i = 0; i < length; i++) {
                if (original[i] != expectation[i]) {
                    throw new InvalidOperationException($"Byte mismatch at offset {i}: expected 0x{expectation[i]:X2}, found 0x{original[i]:X2}");
                }
            }
        }
    }
}

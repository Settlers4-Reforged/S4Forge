using Forge.Config;
using Forge.Native;
using Forge.Native.MemoryPatcher;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;


namespace Forge.Patching {
    public abstract class GamePatchBuilder<T> where T : GamePatchBuilder<T> {
        // ReSharper disable once InconsistentNaming
        static GamePatchBuilder() {
            S4_Main = DI.Resolve<IGameValues>().S4_Main;
        }

        protected static int S4_Main { get; }

        protected nint? sourceAddress;
        public T At(int address) {
            sourceAddress = new nint(address);
            return (T)this;
        }
        public T AtS4(int address) {
            sourceAddress = new nint(address + S4_Main);
            return (T)this;
        }

        protected byte[]? expectedBytes;
        public T ExpectedBytes(params byte[] expectedSourceBytes) {
            expectedBytes = expectedSourceBytes;
            return (T)this;
        }

        [MemberNotNull(nameof(sourceAddress))]
        protected virtual void ValidateRequiredValues() {
            if (sourceAddress == null) {
                throw new InvalidOperationException("Source address must be set");
            }
        }

        public abstract IPatch Build();
    }

    public sealed class PatchBuilder : GamePatchBuilder<PatchBuilder> {
        private byte[]? patchBytes;
        public PatchBuilder PatchBytes(params byte[] patch) {
            patchBytes = patch;
            return this;
        }

        public PatchBuilder PatchBytes(uint patch) {
            patchBytes = BitConverter.GetBytes(patch);
            return this;
        }

        [MemberNotNull(nameof(patchBytes))]
        protected override void ValidateRequiredValues() {
            base.ValidateRequiredValues();

            if (patchBytes == null) {
                throw new InvalidOperationException("Patch bytes must be set");
            }
        }

        public override IPatch Build() {
            ValidateRequiredValues();

            Patch patch = new Patch(sourceAddress.Value.ToInt32(), patchBytes); ;
            if (expectedBytes != null)
                patch.AssertExpectedBytes(expectedBytes);

            return patch;
        }
    }

    public sealed class CallPatchBuilder : GamePatchBuilder<CallPatchBuilder> {
        private nint? destinationAddress;
        // Methods: 0xE8 (call), 0xE9 (jmp)
        private byte method = 0xE8;
        private int nops;

        [MemberNotNull(nameof(destinationAddress))]
        protected override void ValidateRequiredValues() {
            base.ValidateRequiredValues();

            if (destinationAddress == null) {
                throw new InvalidOperationException("Destination address must be set");
            }
        }

        public CallPatchBuilder To(int address) {
            destinationAddress = new nint(address);
            return this;
        }
        public CallPatchBuilder ToS4(int address) {
            destinationAddress = new nint(address + S4_Main);
            return this;
        }

        public CallPatchBuilder ToDelegate(Delegate destination) {
            destinationAddress = Marshal.GetFunctionPointerForDelegate(destination);
            return this;
        }
        public CallPatchBuilder AddNops(int length) {
            nops = length;
            return this;
        }

        public CallPatchBuilder UseJmp() {
            method = 0xE9;
            return this;
        }

        public override IPatch Build() {
            ValidateRequiredValues();

            JmpPatch patch = new JmpPatch(sourceAddress.Value, destinationAddress.Value, nops, method);
            if (expectedBytes != null)
                patch.AssertExpectedBytes(expectedBytes);

            return patch;
        }
    }

    public sealed class NopPatchBuilder : GamePatchBuilder<NopPatchBuilder> {
        private int? length;

        [MemberNotNull(nameof(length))]
        protected override void ValidateRequiredValues() {
            base.ValidateRequiredValues();

            if (length == null) {
                throw new InvalidOperationException("Length must be set");
            }
        }

        public NopPatchBuilder Length(int length) {
            this.length = length;
            return this;
        }

        public override IPatch Build() {
            ValidateRequiredValues();

            NopPatch patch = new NopPatch(sourceAddress.Value, length.Value);
            if (expectedBytes != null)
                patch.AssertExpectedBytes(expectedBytes);

            return patch;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Native.MemoryPatcher {
    public interface IPatch {
        void Apply();
        void Revert();

        void AssertExpectedBytes(byte[] expectation);

        public bool IsApplied { get; }
    }
}

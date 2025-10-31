using Forge.Native;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Game.Core {
    public unsafe readonly struct wstringWrapper : IDisposable {
        readonly GCHandle textHandle;
        readonly wstring nativeText;

        public wstringWrapper(ref string text) {
            this.textHandle = GCHandle.Alloc(text, GCHandleType.Pinned);

            this.nativeText = new wstring {
                storage = new wstring._storage_e__Union {
                    text = (short*)textHandle.AddrOfPinnedObject(),
                },
                size = text.Length,
                capacity = text.Length,
            };
        }

        public static implicit operator IntPtr(wstringWrapper wrapper) {
            return (nint)(&wrapper.nativeText);
        }

        public static implicit operator wstring*(wstringWrapper wrapper) {
            return &wrapper.nativeText;
        }

        public void Dispose() {
            if (textHandle.IsAllocated) {
                textHandle.Free();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Native {

    [DebuggerDisplay("{Text}")]
    public unsafe partial struct wstring {
        public string Text {
            get {
                fixed (wstring* t = &this) {
                    nint pText;

                    if (capacity <= 16) {
                        pText = (nint)(t->storage.buffer);
                    } else {
                        pText = (nint)(t->storage.text);
                    }

                    return Marshal.PtrToStringUTF8(pText) ?? "unknown";
                }
            }
        }
    }
}

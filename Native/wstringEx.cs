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

                    if (field_14 <= 16) {
                        pText = (nint)(&t->text);
                    } else {
                        pText = (nint)t->text;
                    }

                    return Marshal.PtrToStringAnsi(pText) ?? "unknown";
                }
            }
        }
    }
}

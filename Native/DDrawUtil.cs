using Forge.Config;
using Forge.Logging;
using Forge.Native.DirectX;

using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace Forge.Native {
    public static unsafe class DDrawUtil {

        public static IDirectDraw7* device;

        static DDrawUtil() {
            FetchDevice();
        }

        [Obsolete("Use DI.Resolve<IDirectDraw7>() instead")]
        public static void FetchDevice() {
            void* ddrawDevice = (void*)DI.Resolve<IGameValues>().ReadValue<int>(0x1057F7C);
            if ((int)ddrawDevice == 0) {
                throw new ArgumentNullException("ddrawDevice", "Failed to retrieve DirectDraw7 device from settlers 4");
            }

            device = (IDirectDraw7*)ddrawDevice;
        }
    }
}

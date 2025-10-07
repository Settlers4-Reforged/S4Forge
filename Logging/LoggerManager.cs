using DryIoc;

using Forge.Config;
using Forge.Native;
using Forge.Native.MemoryPatcher;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using static Forge.Logging.CLogger;

namespace Forge.Logging {
    public partial class LoggerManager {
        internal static CLogger ForgeLogger = new CLogger("S4Forge");
        private static CLogger NativeLogger = new CLogger("Native");

        /// <summary>
        /// Configures the CLogger to use the Forge Bootstrapper's logging mechanism.
        /// </summary>
        public static void PrepareLogger(SendLogCallback? sendLogDelegate = null) {
            if (sendLogDelegate != null) {
                CLogger.SendLog = sendLogDelegate;
            }

            DI.Dependencies.Register(
                Made.Of(() => new CLogger(Arg.Index<string>(0), "Test"),
                    req => {
                        return req.Parent?.ImplementationType?.Assembly?.GetName()?.Name ?? "Unknown";
                    }
                )
            );
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        unsafe delegate void CBBSupportLogFile_WriteToFileDelegate(void* _this, void* text, uint length);
        static CBBSupportLogFile_WriteToFileDelegate WriteToFileOrig;
        public unsafe static void WriteToFileRedirect(void* _this, void* text, uint length) {
            WriteToFileOrig(_this, text, length);

            string output = Marshal.PtrToStringAnsi((nint)text) ?? "BROKEN WRITE";
            string trimmedOutput = output.Trim('\n', '\r');
            if (trimmedOutput.Length > 0)
                NativeLogger.Log(LogLevel.Debug, trimmedOutput);
        }

        public static unsafe void SetupS4LoggingRedirect() {
            IntPtr fptr = Marshal.GetFunctionPointerForDelegate<CBBSupportLogFile_WriteToFileDelegate>(WriteToFileRedirect);
            IGameValues gameValues = DI.Resolve<IGameValues>();


            uint CBBSupportTraceFileVtable_WriteToFile = gameValues.ReadValue<uint>(0xC6C200);
            WriteToFileOrig = Marshal.GetDelegateForFunctionPointer<CBBSupportLogFile_WriteToFileDelegate>(new IntPtr(CBBSupportTraceFileVtable_WriteToFile));

            IPatch patch = new PatchBuilder().AtS4(0xC6C200).PatchBytes((uint)fptr).Build();
            patch.Apply();
        }
    }
}

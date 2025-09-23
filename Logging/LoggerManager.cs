using DryIoc;

using Forge.Config;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Logging {
    public partial class LoggerManager {
        [LibraryImport("S4ForgeBootstrapper.asi", EntryPoint = "LogMessage", StringMarshalling = StringMarshalling.Utf16)]
        internal static partial void LogMessage(
            LogLevel level,
            string assembly,
            string category,
            string message);


        internal static CLogger ForgeLogger = new CLogger("S4Forge");


        /// <summary>
        /// Configures the CLogger to use the Forge Bootstrapper's logging mechanism.
        /// </summary>
        public static void PrepareLogger() {
            CLogger.SendLog = LogMessage;

            DI.Dependencies.Register(
                Made.Of(() => new CLogger(Arg.Index<string>(0), "Test"),
                    req => {
                        return req.Parent?.ImplementationType?.Assembly?.GetName()?.Name ?? "Unknown";
                    }
                )
            );
        }


    }
}

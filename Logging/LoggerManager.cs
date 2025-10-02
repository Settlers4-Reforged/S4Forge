using DryIoc;

using Forge.Config;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using static Forge.Logging.CLogger;

namespace Forge.Logging {
    public partial class LoggerManager {
        internal static CLogger ForgeLogger = new CLogger("S4Forge");

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
    }
}

using Forge.Logging;
using Forge.Native;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Engine {
    public interface IForge {
        void Initialize(IS4ModApi modApi, IDebugService debugReporter, CLogger.SendLogCallback logWriter);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Forge.Logging {

    public interface IDebugService {
        void ReportException(DebugReportSource source, string message, Exception exception, bool fatal);
        void ReportGeneric(DebugReportSource source, string message);
        bool AddPropertyToReport(string name, string value);
        bool AddFileToReport(string file);

        void SetGpuInfo(string vendor, string gpuName, string renderer);

        string GetFullStacktrace(int skip, bool skipToFirstManaged);

        [Obsolete("Use CLogger")]
        void Log(string origin, string message);
    };
}

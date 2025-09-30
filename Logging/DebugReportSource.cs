namespace Forge.Logging {
    public struct DebugReportSource {
        // The source name (often your plugin name), as in the project registered with CrashRpt
        public string Application;
        // The current source version
        public string Version;

        // A custom target URL for the crash report upload, only applicable if non default
        public string TargetUrl;
        // A custom privacy policy URL, only applicable if non default
        public string PrivacyPolicyUrl;

        // The path to the language file for the crash report, only applicable if non default
        public string LangFilePath;
    };
}

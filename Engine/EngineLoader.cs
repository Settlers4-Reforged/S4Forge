using DryIoc;

using Forge.Config;
using Forge.Logging;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Forge.Engine {
    internal static class EngineLoader {
        private static CLogger Logger = LoggerManager.ForgeLogger.WithEnumCategory(ForgeLogCategory.Setup);

        public static Type? GetIEngine(Assembly assembly) {
            Type[] types = assembly.GetExportedTypes();

            Type? iEngine = (from Type t in types
                             where t.GetInterface(nameof(IEngine)) != null
                             select t).FirstOrDefault();

            return iEngine;
        }

        private static readonly string[] Engines = new string[] { "UX-Engine.dll", "NetEngine.dll" };
        private const string EnginePath = @"\plugins\Forge\Engines\";
        private static string AbsoluteEnginePath => Environment.CurrentDirectory + EnginePath;

        internal static void LoadAllEngines(Container dependencies) {
            RegisterAvailableEngines(DI.Dependencies);

            var engines = DI.Dependencies.ResolveMany<IEngine>();
            foreach (IEngine engine in engines) {
                Logger.Log(LogLevel.Info, $"Initializing \"{engine.Name}\"...");
                engine.Initialize();
                Logger.Log(LogLevel.Info, $"Finished initializing \"{engine.Name}\"...");
            }

        }

        private static void RegisterAvailableEngines(Container dependencies) {
            Logger.Log(LogLevel.Info, "Searching for available engines...");
            Logger.LogF(LogLevel.Debug, "Searching for the following engines: {0}", string.Join(", ", Engines));

            foreach (string engine in Engines) {
                if (!System.IO.File.Exists(AbsoluteEnginePath + engine)) {
                    Logger.LogF(LogLevel.Warning, "Engine \"{0}\" not found at \"{1}\"", engine, AbsoluteEnginePath);
                    continue;
                }

                try {
                    Assembly engineAssembly = Assembly.LoadFile(AbsoluteEnginePath + engine);

                    AssemblyInitializations.AddAssemblyLoadSource(engineAssembly);

                    Type? iEngine = GetIEngine(engineAssembly);
                    if (iEngine == null) {
                        throw new EntryPointNotFoundException($"Failed to find IEngine in engine \"{engine}\"");
                    }

                    dependencies.RegisterMany(new[] { iEngine }, Reuse.Singleton);

                    Logger.LogF(LogLevel.Info, "Registered engine \"{0}\" at \"{1}\"", engine, AbsoluteEnginePath);
                } catch (Exception ex) {
                    Logger.TraceExceptionF(LogLevel.Error, ex, "Failed to load engine \"{0}\" at \"{1}\"", engine, AbsoluteEnginePath);
                }
            }
        }
    }
}

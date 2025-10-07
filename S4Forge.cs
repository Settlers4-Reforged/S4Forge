using DryIoc;

using Forge.Config;
using Forge.Engine;
using Forge.Game.Core;
using Forge.Logging;
using Forge.Native;
using Forge.Notifications;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Forge {
    public class S4Forge : IForge {
        private CLogger Logger = LoggerManager.ForgeLogger.WithEnumCategory(ForgeLogCategory.Core);

        private IDebugService DebugReporter;

        // TODO: .NET Counters!!
        public void Initialize(IS4ModApi modApi, IDebugService debugReporter, CLogger.SendLogCallback logWriter) {
            DebugReporter = debugReporter;
            LoggerManager.PrepareLogger(logWriter);

            Logger.Log(LogLevel.Info, "Initializing Forge...");

            AssemblyInitializations.InitAssemblyLoadHandler();
            AddExceptionHandling();

            DI.Dependencies.RegisterInstanceMany(this);
            DI.Dependencies.RegisterInstanceMany(DebugReporter);
            DI.Dependencies.RegisterInstance<IS4ModApi>(modApi);
            DI.Dependencies.Register<IGameValues, GameValues>();
            DI.Dependencies.Register<ICallbacks, Callbacks>(Reuse.Singleton);
            ApiManager.RegisterDependencies();
            NotificationsService.RegisterDependencies();

            LoggerManager.SetupS4LoggingRedirect(); // requires IGameValues

            EngineLoader.LoadAllEngines(DI.Dependencies);

            ApiManager.ResolveDependencies();

            if (!ModuleLoader.LoadAllModules(DI.Dependencies)) {
                Logger.Log(LogLevel.Error, "There was an error during the loading of one (or all) modules");
            } else {
                Logger.Log(LogLevel.Info, "Finished loading all modules");
            }

            ModuleLoader.InformModulesLoadedCallbacks(DI.Dependencies);

            Logger.Log(LogLevel.Debug, "Activating all registered plugins");
            var genericPlugins = DI.Dependencies.Resolve<IPlugin[]>();
            foreach (var plugin in genericPlugins) {
                plugin.Activate();
            }

            Logger.Log(LogLevel.Info, "Finished initializing Forge");
        }

        private void AddExceptionHandling() {
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler;
            AppDomain.CurrentDomain.FirstChanceException += AppendNativeStackToExceptionHandler;
            Logger.Log(LogLevel.Info, "Added exception handling");
        }

        private void AppendNativeStackToExceptionHandler(object? sender, FirstChanceExceptionEventArgs e) {
            // NOTE(Jonas): This _could_ lead to a stack overflow as we maybe trip into an exception when rendering the stack trace
            // I don't quite know how to correctly detect that, so just hopes and prayers keep this code here together
            e.Exception.Data.Add("Stack", DebugReporter.GetFullStacktrace(6, true));
        }

        private void UnhandledExceptionHandler(object s, UnhandledExceptionEventArgs e) {
            Exception exception = (Exception)e.ExceptionObject;

            Logger.TraceExceptionF(LogLevel.Error, exception, "Forge detected an unhandled exception");

#if DEBUG
            User32.MessageBox($"Forge detected an unhandled managed exception and is now halting execution.\n{exception.Message}\nEither attach a debugger, or ignore this error", "S4Forge");
#endif

            DebugReportSource source = new DebugReportSource();

            string exceptionMessage = "";
            // TODO: Add custom exception handling for plugins
            // Probably in form of a custom class in the plugin assembly that implements ICrashReporter
            DebugReporter.ReportException(source, exceptionMessage, exception, true);
        }

    }
}

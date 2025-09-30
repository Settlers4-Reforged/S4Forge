using Forge.Engine;

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Forge.Logging {
    /// <summary>
    /// A contexted logger
    /// </summary>
    public readonly struct CLogger {
        /// <summary>
        /// Gets the category associated with the current instance.
        /// </summary>
        public readonly string Category { get; } = "Generic";
        public readonly string Assembly { get; }


        public delegate void SendLogCallback(LogLevel level, string assembly, string category, string message);
        /// <summary>
        /// Inversion of control delegate for sending log messages.
        /// </summary>
        internal static SendLogCallback SendLog =
            (level, assembly, category, message) => Console.WriteLine($"[{level}] [{assembly}] [{category}] {message}");

        internal static IDebugService? DebugService;

        public CLogger() { }
        public CLogger(string assembly) {
            Assembly = assembly;
        }
        public CLogger(string assembly, string category) {
            Assembly = assembly;
            Category = category;
        }

        /// <summary>
        /// Creates a new instance of <see cref="CLogger"/> with the specified category name.
        /// </summary>
        /// <param name="category">The category name to associate with the logger. Cannot be null or empty.</param>
        /// <returns>A new <see cref="CLogger"/> instance configured with the specified category.</returns>
        public CLogger WithCategory(string category) => new CLogger(this.Assembly, category);

        /// <summary>
        /// Creates a new <see cref="CLogger"/> instance with the specified enum category as its logging category.
        /// </summary>
        /// <typeparam name="T">The type of the enum used as the logging category.</typeparam>
        /// <param name="category">The enum value representing the logging category. If the enum value cannot be resolved to a name, the
        /// category will default to "UNKNOWN".</param>
        /// <returns>A new <see cref="CLogger"/> instance configured with the specified enum as category name.</returns>
        public CLogger WithEnumCategory<T>(T category) where T : struct, Enum => new CLogger(this.Assembly, Enum.GetName<T>(category) ?? "UNKNOWN");

        /// <summary>
        /// Creates a new instance of <see cref="CLogger"/> using the name of the calling assembly  as the context and
        /// retaining the current logger's category.
        /// </summary>
        /// <remarks>This method is useful for creating a logger instance that is scoped to the calling
        /// assembly,  while preserving the category of the current logger. 
        /// 
        /// It is not needed when the logger is injected via dependency injection in the constructor.
        /// 
        /// If the calling assembly's name cannot be determined, the context defaults to "Unknown".</remarks>
        /// <returns>A new <see cref="CLogger"/> instance with the calling assembly's name as the context and the current
        /// logger's category.</returns>
        public CLogger WithCurrentContext() {
            return new CLogger(System.Reflection.Assembly.GetCallingAssembly().GetName().Name ?? "Unknown", this.Category);
        }

        /// <summary>
        /// Logs a message with the specified log level.
        /// </summary>
        /// <remarks>Use this method to record diagnostic or operational information at a specific log
        /// level. Ensure that <paramref name="message"/> provides meaningful context for the log entry.</remarks>
        /// <param name="level">The severity level of the log message. Must be one of the predefined <see cref="LogLevel"/> values.</param>
        /// <param name="message">The message to log. Cannot be null or empty.</param>
        public void Log(LogLevel level, string message) {
            SendLog(level, Assembly, Category, message);
        }

        /// <summary>
        /// Logs a formatted message at the specified log level.
        /// </summary>
        /// <remarks>The <paramref name="message"/> template can include placeholders in the form of
        /// `{0}`, `{1}`, etc., which will be replaced by the corresponding values in <paramref
        /// name="formatParameters"/>. Ensure that the number of placeholders in the message matches the number of
        /// format parameters provided.</remarks>
        /// <param name="level">The severity level of the log message. Must be a valid <see cref="LogLevel"/> value.</param>
        /// <param name="message">The message template to log. Can include placeholders for formatting.</param>
        /// <param name="formatParameters">An array of objects to format into the placeholders in the <paramref name="message"/> template.</param>
        public void LogF(LogLevel level, string message, params object[] formatParameters) {
            string formattedMessage = string.Format(CultureInfo.InvariantCulture, message, formatParameters);
            Log(level, formattedMessage);
        }

        /// <summary>
        /// Logs an exception along with a formatted message and stack trace information.
        /// </summary>
        /// <remarks>If the <paramref name="exception"/> contains a custom stack trace in its
        /// <c>Data["Stack"]</c> property, that stack trace will be used in the log entry. Otherwise, a default stack
        /// trace is generated.</remarks>
        /// <param name="level">The severity level of the log entry.</param>
        /// <param name="exception">The exception to log. If <see langword="null"/>, a stack trace will still be included.</param>
        /// <param name="message">The message template to format and include in the log entry.</param>
        /// <param name="formatParameters">An array of objects to format into the <paramref name="message"/> template.</param>
        public void TraceExceptionF(LogLevel level, Exception? exception, string message, params object[] formatParameters) {
            string formattedMessage = string.Format(CultureInfo.InvariantCulture, message, formatParameters);

            string stack;
            if (exception?.Data["Stack"] == null) {
                stack = DebugService?.GetFullStacktrace(8, false) ?? "-- no stacktrace --";
            } else {
                stack = exception.Data["Stack"]!.ToString()!;
            }

            formattedMessage += "\n### Stack Trace ###\n" + stack;


            Log(level, formattedMessage);
        }

        /// <summary>
        /// Logs a formatted message at the specified log level.
        /// Also logs the current stack trace.
        /// </summary>
        /// <remarks>This method formats the <paramref name="message"/> using the provided <paramref
        /// name="formatParameters"/>  and logs it at the specified <paramref name="level"/>. If no format parameters
        /// are provided, the message  is logged as-is.</remarks>
        /// <param name="level">The severity level of the log message.</param>
        /// <param name="message">The message template to log. Can include format placeholders.</param>
        /// <param name="formatParameters">An array of objects to format into the message template.</param>
        public void TraceF(LogLevel level, string message, params object[] formatParameters) {
            TraceExceptionF(level, null, message, formatParameters);
        }
    }
}


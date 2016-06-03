using System;
using System.Collections.Generic;

namespace DesignPatterns._01_PatternsOfBehavior_Chapter1.Strategy
{
    /// <summary>
    /// В случае, когда стратегия определяет лишь 1 операцию, то вместо выделения и
    /// передачи интерфейса часто используется делегат.
    /// </summary>
    public class LogProcessor
    {
        private readonly Func<List<LogEntry>> _logImporter;

        public LogProcessor(Func<List<LogEntry>> logImporter)
        {
            _logImporter = logImporter;
        }

        public void ProcessLogs()
        {
            foreach (LogEntry logEntry in _logImporter.Invoke())
            {
                SaveLogEntry(logEntry);
            }
        }

        private void SaveLogEntry(LogEntry logEntry)
        {
            
        }
    }

    /// <summary>
    /// А можно через интерфейс
    /// </summary>
    public class LogProcessor1
    {
        private readonly ILogReader _logReader;

        public LogProcessor1(ILogReader logReader)
        {
            _logReader = logReader;
        }

        public void ProcessLogs()
        {
            foreach (LogEntry logEntry in _logReader.Read())
            {
                SaveLogEntry(logEntry);
            }
        }

        private void SaveLogEntry(LogEntry logEntry)
        {

        }
    }
}

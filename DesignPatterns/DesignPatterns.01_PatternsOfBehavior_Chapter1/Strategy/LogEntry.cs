using System;

namespace DesignPatterns._01_PatternsOfBehavior_Chapter1.Strategy
{
    public class LogEntry
    {
        public DateTime DateTime { get; set; }
        public string Severity { get; set; }
        public string Message { get; set; }
    }
}

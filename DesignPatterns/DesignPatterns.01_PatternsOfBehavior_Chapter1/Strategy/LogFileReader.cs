using System;
using System.Collections.Generic;

namespace DesignPatterns._01_PatternsOfBehavior_Chapter1.Strategy
{
    public class LogFileReader : ILogReader
    {
        public List<LogEntry> Read()
        {
            return new List<LogEntry>();
        }
    }
}

using System.Collections.Generic;

namespace DesignPatterns._01_PatternsOfBehavior_Chapter1.Strategy
{
    public interface ILogReader
    {
        List<LogEntry> Read();
    }
}

using System;

namespace log_analysis
{
    public static class LogAnalysis
    {
        // TODO: define the 'SubstringAfter()' extension method on the `string` type
        public static string SubstringAfter(this string logLine, string str)
        {
            string[] log = logLine.Split(str);
            return log[1];
        }

        // TODO: define the 'SubstringBetween()' extension method on the `string` type
        public static string SubstringBetween(this string logLine, string separadorp, string separadors)
        {
            string[] log = logLine.Split(separadorp);
            string[] logs = log[1].Split(separadors);

            return logs[0];
        }

        // TODO: define the 'Message()' extension method on the `string` type
        public static string Message(this string logLine)
        {
            return logLine.SubstringAfter(": ");
        }

        // TODO: define the 'LogLevel()' extension method on the `string` type
        public static string LogLevel(this string logLine)
        {
            return logLine.SubstringBetween("[", "]");
        }
    }
}
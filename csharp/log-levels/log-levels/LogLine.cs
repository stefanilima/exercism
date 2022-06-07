using System;
namespace log_levels
{
    static class LogLine
    {
        public static string Message(string logLine)
        {
            char[] remove = {' ', '\r', '\n', '\t'};
            string[] str = logLine.Split(':');

            return str[1].TrimEnd(remove).TrimStart(remove);
        }

        public static string LogLevel(string logLine)
        {
            char[] remove = {'['};
            string[] str = logLine.Split(']');

            return str[0].ToLower().TrimStart(remove);
        }

        public static string Reformat(string logLine)
        {
            string message = Message(logLine);
            string level = LogLevel(logLine);


            return $"{message} ({level})";
        }
    }

}

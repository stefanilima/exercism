using System;

namespace log_analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var log = "[INFO]: File Deleted.";
            Console.WriteLine(log.SubstringAfter(": ")); // => returns "File Deleted."
            Console.WriteLine(log.SubstringBetween("[", "]")); // => returns "INFO"
            Console.WriteLine(log.Message()); // => returns "Missing ; on line 20.")
            Console.WriteLine(log.LogLevel()); // => returns "ERROR")
        }
    }
}

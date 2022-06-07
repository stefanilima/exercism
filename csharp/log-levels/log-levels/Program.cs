using System;

namespace log_levels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(LogLine.Message("[ERROR]: Invalid operation"));
            Console.WriteLine(LogLine.Message("[INFO]: Timezone changed"));
            Console.WriteLine(LogLine.Message("[WARNING]: Disk almost full"));
            Console.WriteLine(LogLine.Message("[WARNING]:  Disk almost full\r\n"));

            Console.WriteLine(LogLine.LogLevel("[ERROR]: Invalid operation"));
            Console.WriteLine(LogLine.LogLevel("[WARNING]: Unsafe password"));
            Console.WriteLine(LogLine.LogLevel("[INFO]: Timezone changed"));

            Console.WriteLine(LogLine.Reformat("[ERROR]: Segmentation fault"));
            Console.WriteLine(LogLine.Reformat("[WARNING]: Decreased performance"));
            Console.WriteLine(LogLine.Reformat("[INFO]: Operation completed"));
            Console.WriteLine(LogLine.Reformat("[ERROR]: \t Corrupt disk\t \t \r\n"));

        }
    }
}

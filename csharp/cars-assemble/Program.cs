using System;

namespace cars_assemble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(AssemblyLine.SuccessRate(0));
            Console.WriteLine(AssemblyLine.SuccessRate(1));
            Console.WriteLine(AssemblyLine.SuccessRate(4));
            Console.WriteLine(AssemblyLine.SuccessRate(9));
            Console.WriteLine(AssemblyLine.SuccessRate(10));

            Console.WriteLine(AssemblyLine.ProductionRatePerHour(0));
            Console.WriteLine(AssemblyLine.ProductionRatePerHour(1));
            Console.WriteLine(AssemblyLine.ProductionRatePerHour(4));
            Console.WriteLine(AssemblyLine.ProductionRatePerHour(7));

            Console.WriteLine(AssemblyLine.WorkingItemsPerMinute(0));
            Console.WriteLine(AssemblyLine.WorkingItemsPerMinute(1));
            Console.WriteLine(AssemblyLine.WorkingItemsPerMinute(5));
            Console.WriteLine(AssemblyLine.WorkingItemsPerMinute(8));
            Console.WriteLine(AssemblyLine.WorkingItemsPerMinute(9));
            Console.WriteLine(AssemblyLine.WorkingItemsPerMinute(10));
        }
    }
}

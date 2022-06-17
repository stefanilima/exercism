using System;

namespace CarsAssemble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Cars, Assemble!");

            Console.WriteLine(AssemblyLine.SuccessRate(1));
            Console.WriteLine(AssemblyLine.ProductionRatePerHour(4));
            Console.WriteLine(AssemblyLine.WorkingItemsPerMinute(9));
        }
    }
}

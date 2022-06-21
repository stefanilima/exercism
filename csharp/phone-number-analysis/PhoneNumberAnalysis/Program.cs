using System;

namespace PhoneNumberAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var number = PhoneNumber.Analyze("631-555-1234");

            Console.WriteLine(number.IsFake);
            Console.WriteLine(number.IsNewYork);
            Console.WriteLine(number.LocalNumber);

            PhoneNumber.IsFake(number);
        }
    }
}

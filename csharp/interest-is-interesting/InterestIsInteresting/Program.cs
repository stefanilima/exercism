using System;

namespace InterestIsInteresting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(SavingsAccount.InterestRate(200.75m));
            SavingsAccount.Interest(200.75m);
        }
    }
}

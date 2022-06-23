using System;

namespace InterestIsInteresting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SavingsAccount.InterestRate(200.75m);
            SavingsAccount.Interest(200.75m);
            Console.WriteLine(SavingsAccount.AnnualBalanceUpdate(balance: 200.75m));
            SavingsAccount.YearsBeforeDesiredBalance(balance: 200.75m, targetBalance: 214.88m);
        }
    }
}

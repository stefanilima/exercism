using System;
namespace InterestIsInteresting
{
    public static class SavingsAccount
    {
        public static float InterestRate(decimal balance)
        {
            if (balance < 0) return 3.213f;
            else if (balance < 1000) return 0.5f;
            else if (balance >= 1000 && balance < 5000) return 1.621f;
            else return 2.475f;
        }

        public static decimal Interest(decimal balance)
        {
            var taxaJuros = InterestRate(balance);
            decimal juros = (balance / 100) * ((decimal)taxaJuros);

            Console.WriteLine(juros);

            return 0;
            //throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
        }

        public static decimal AnnualBalanceUpdate(decimal balance)
        {
            throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
        }

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
        }
    }
}

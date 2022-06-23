using System;
using InterestIsInteresting;
using Xunit;

namespace InterestIsInterestingTests
{
    public class SavingsAccountTest
    {
        [Fact]
        public void InterestRateWithBalanceNegativo()
        {
            Assert.Equal(3.213f, SavingsAccount.InterestRate(-1));
        }

        [Fact]
        public void InterestRateWithLessBalanceThousand()
        {
            Assert.Equal(0.5f, SavingsAccount.InterestRate(999));
        }

        [Fact]
        public void InterestRateWithBalanceEqualToThousand()
        {
            Assert.Equal(1.621f, SavingsAccount.InterestRate(1000));
        }

        [Fact]
        public void InterestRateWithBalanceGreaterLessThanFiveThousand()
        {
            Assert.Equal(1.621f, SavingsAccount.InterestRate(4001));
        }

        [Fact]
        public void InterestRateWithBalanceGreaterThanFiveThousand()
        {
            Assert.Equal(2.475f, SavingsAccount.InterestRate(5001));
        }
    }
}

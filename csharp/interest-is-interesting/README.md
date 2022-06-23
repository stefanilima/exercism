# Interest is Interesting!

My solution to the Interest is Interesting exercise.

[My profile Exercism](https://exercism.org/profiles/stefanilima)

[Exercism Link](https://exercism.org/tracks/csharp/exercises/interest-is-interesting)

### Run the tests

To run the tests use Visual Studio or the `dotnet test` command.

## Instructions

In this exercise you'll be working with savings accounts. Each year, the balance of your savings account is updated based on its interest rate. The interest rate your bank gives you depends on the amount of money in your account (its balance):

- 3.213% for a negative balance (balance gets more negative).
- 0.5% for a positive balance less than 1000 dollars.
- 1.621% for a positive balance greater than or equal to 1000 dollars and less than 5000 dollars.
- 2.475% for a positive balance greater than or equal to 5000 dollars.

You have four tasks, each of which will deal your balance and its interest rate.

### 1. Calculate the interest rate
Implement the (static) `SavingsAccount.InterestRate()` method to calculate the interest rate based on the specified balance:

```
SavingsAccount.InterestRate(balance: 200.75m)
// 0.5f
```

Note that the value returned is a float.

### 2. Calculate the interest
Implement the (static) `SavingsAccount.Interest()` method to calculate the interest based on the specified balance:

```
SavingsAccount.Interest(balance: 200.75m)
// 1.00375m
```

Note that the value returned is a decimal.

### 3. Calculate the annual balance update
Implement the (static) `SavingsAccount.AnnualBalanceUpdate()` method to calculate the annual balance update, taking into account the interest rate:

```
SavingsAccount.AnnualBalanceUpdate(balance: 200.75m)
// 201.75375m
```

Note that the value returned is a decimal.

### 4. Calculate the years before reaching the desired balance

Implement the (static) `SavingsAccount.YearsBeforeDesiredBalance()` method to calculate the minimum number of years required to reach the desired balance given annually compounding interest:

```
SavingsAccount.YearsBeforeDesiredBalance(balance: 200.75m, targetBalance: 214.88m)
// 14
```
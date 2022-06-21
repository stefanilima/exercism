# Phone Number Analysis

My solution to the Phone Number Analysis exercise.

[My profile Exercism](https://exercism.org/profiles/stefanilima)

[Exercism Link](https://exercism.org/tracks/csharp/exercises/phone-number-analysis)

### Run the tests

To run the tests use Visual Studio or the `dotnet test` command.

## Instructions

This exercise has you analyze phone numbers.

You are asked to implement 2 features.

Phone numbers passed to the routines are guaranteed to be in the form NNN-NNN-NNNN e.g. 212-515-9876 and non-null.

### 1. Analyze a phone number

Your analysis should return 3 pieces of data

1. An indication of whether the number has a New York dialing code ie. 212 as the first 3 digits
1. An indication of whether the number is fake having 555 as a prefix code in positions 5 to 7 (numbering from 1)
1. The last 4 digits of the number.

Implement the (static) method `PhoneNumber.Analyze()` to produce the phone number info.

```
PhoneNumber.Analyze("631-555-1234");
// => (false, true, "1234")
````

### 2. Detect if a phone number has a fake prefix code (555)

Implement the (static) method `PhoneNumber.IsFake()` to detect whether the phone number is fake using the phone number info produced in task 1.

```
PhoneNumber.IsFake(PhoneNumbers.Analyze("631-555-1234"));
// => true
```
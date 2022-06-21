using System;
using PhoneNumberAnalysis;
using Xunit;

namespace PhoneNumberAnalysisTests
{
    public class PhoneNumberTests
    {
        [Fact]
        public void AnalyzeNumberNotIsNewYork()
        {
            var phone = PhoneNumber.Analyze("631-555-1234");

            Assert.False(phone.IsNewYork);
        }

        [Fact]
        public void AnalyzeNumberIsNewYork()
        {
            var phone = PhoneNumber.Analyze("212-555-1234");

            Assert.True(phone.IsNewYork);
        }

        [Fact]
        public void AnalyzeNumberNotIsFake()
        {
            var phone = PhoneNumber.Analyze("212-515-1234");

            Assert.False(phone.IsFake);
        }

        [Fact]
        public void AnalyzeNumberIsFake()
        {
            var phone = PhoneNumber.Analyze("212-555-1234");

            Assert.True(phone.IsFake);
        }

        [Fact]
        public void NumberIsFake()
        {
            var phone = PhoneNumber.Analyze("212-555-1234");

            Assert.True(PhoneNumber.IsFake(phone));
        }

        [Fact]
        public void NumberNotIsFake()
        {
            var phone = PhoneNumber.Analyze("555-212-1234");

            Assert.False(PhoneNumber.IsFake(phone));
        }
    }
}

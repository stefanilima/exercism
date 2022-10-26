using System;
using CarsAssemble;
using Xunit;

namespace CarsAssembleTests
{
    public class AssemblyLineTests
    {
        [Fact]
        public void SuccessRateWithSpeedZero()
        {
            Assert.Equal(0, AssemblyLine.SuccessRate(0));
        }

        [Fact]
        public void SuccessRateWithSpeedOne()
        {
            Assert.Equal(1, AssemblyLine.SuccessRate(1));
        }

        [Fact]
        public void SuccessRateWithSpeedFour()
        {
            Assert.Equal(1, AssemblyLine.SuccessRate(4));
        }

        [Fact]
        public void SuccessRateWithSpeedSeven()
        {
            Assert.Equal(0.9, AssemblyLine.SuccessRate(7));
        }

        [Fact]
        public void SuccessRateWithSpeedNine()
        {
            Assert.Equal(0.8, AssemblyLine.SuccessRate(9));
        }

        [Fact]
        public void SuccessRateWithSpeedTen()
        {
            Assert.Equal(0.77, AssemblyLine.SuccessRate(10));
        }

        [Fact]
        public void ProductionRatePerHourWithSpeedZero()
        {
            Assert.Equal(0, AssemblyLine.ProductionRatePerHour(0));
        }

        [Fact]
        public void ProductionRatePerHourWithSpeedOne()
        {
            Assert.Equal(221, AssemblyLine.ProductionRatePerHour(1));
        }

        [Fact]
        public void ProductionRatePerHourWithSpeedFour()
        {
            Assert.Equal(884, AssemblyLine.ProductionRatePerHour(4));
        }

        [Fact]
        public void ProductionRatePerHourWithSpeedSeven()
        {
            Assert.Equal(1392.3, AssemblyLine.ProductionRatePerHour(7));
        }

        [Fact]
        public void WorkingItemsPerMinuteWithSpeedZero()
        {
            Assert.Equal(0, AssemblyLine.WorkingItemsPerMinute(0));
        }

        [Fact]
        public void WorkingItemsPerMinuteWithSpeedOne()
        {
            Assert.Equal(3, AssemblyLine.WorkingItemsPerMinute(1));
        }

        [Fact]
        public void WorkingItemsPerMinuteWithSpeedFive()
        {
            Assert.Equal(16, AssemblyLine.WorkingItemsPerMinute(5));
        }

        [Fact]
        public void WorkingItemsPerMinuteWithSpeedEight()
        {
            Assert.Equal(26, AssemblyLine.WorkingItemsPerMinute(8));
        }

        [Fact]
        public void WorkingItemsPerMinuteWithSpeedNine()
        {
            Assert.Equal(26, AssemblyLine.WorkingItemsPerMinute(9));
        }

        [Fact]
        public void WorkingItemsPerMinuteWithSpeedTen()
        {
            Assert.Equal(11128, AssemblyLine.WorkingItemsPerMinute(10));
        }
    }
}

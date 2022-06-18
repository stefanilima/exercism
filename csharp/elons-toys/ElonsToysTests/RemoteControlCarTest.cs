using System;
using ElonsToys;
using Xunit;

namespace ElonsToysTests
{
    public class RemoteControlCarTest
    {
        [Fact]
        public void BuyNewCarReturnsInstance()
        {
            var car = RemoteControlCar.Buy();
            Assert.NotNull(car);
        }

        [Fact]
        public void BuyNewCarReturnsNewCarEachTime()
        {
            var car1 = RemoteControlCar.Buy();
            var car2 = RemoteControlCar.Buy();
            Assert.NotSame(car2, car1);
        }

        [Fact]
        public void DistanceDisplayWithZeroMeters()
        {
            var car = RemoteControlCar.Buy();
            Assert.Contains("Driven 0 meters", car.DistanceDisplay());
        }

        [Fact]
        public void NewCarWithFullBatteryDisplay()
        {
            var car = RemoteControlCar.Buy();
            Assert.Contains("Battery at 100%", car.BatteryDisplay());
        }

        [Fact]
        public void DistanceDisplayDriveCarOnce()
        {
            var car = RemoteControlCar.Buy();
            car.Drive();
            Assert.Contains("Driven 20 meters", car.DistanceDisplay());
        }

        [Fact]
        public void DistanceDisplayDriveCarTwice()
        {
            var car = RemoteControlCar.Buy();
            car.Drive();
            car.Drive();
            Assert.Contains("Driven 40 meters", car.DistanceDisplay());
        }

        [Fact]
        public void BatteryDisplayDriveCarOnce()
        {
            var car = RemoteControlCar.Buy();
            car.Drive();
            Assert.Contains("Battery at 99%", car.BatteryDisplay());
        }

        [Fact]
        public void BatteryDisplayDriveCarTwice()
        {
            var car = RemoteControlCar.Buy();
            car.Drive();
            car.Drive();
            Assert.Contains("Battery at 98%", car.BatteryDisplay());
        }

        [Fact]
        public void BatteryIsEmpty()
        {
            var car = RemoteControlCar.Buy();

            for(int i = 0; i < 100; i++)
            {
                car.Drive();
            }

            Assert.Contains("Battery empty", car.BatteryDisplay());
        }
    }
}

using System;

namespace ElonsToys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var car = RemoteControlCar.Buy();

            Console.WriteLine(car.DistanceDisplay());
            Console.WriteLine(car.BatteryDisplay());

            car.Drive();

            Console.WriteLine(car.DistanceDisplay());
            Console.WriteLine(car.BatteryDisplay());
        }
    }
}

using System;

namespace BirdWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            var birdCount = new BirdCount(birdsPerDay);
            Console.WriteLine(birdCount.CountForFirstDays(4));
        }
    }
}

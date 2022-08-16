using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] birdsLastWeek = { 0, 2, 5, 3, 7, 8, 4 };
        return birdsLastWeek;
    }

    public int Today()
    {
        return birdsPerDay.LastOrDefault();
    }

    public void IncrementTodaysCount()
    {
        int birdsToday = Today() + 1;
        birdsPerDay[birdsPerDay.Length - 1] = birdsToday;
    }

    public bool HasDayWithoutBirds()
    {
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] == 0)
            {
                return true;
            }
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int countForFirstDays = 0;

        for (int i = 0; i < numberOfDays; i++)
        {
            countForFirstDays += birdsPerDay[i];
        }

        return countForFirstDays;
    }

    public int BusyDays()
    {
        int busyDays = 0;

        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] >= 5)
            {
                busyDays++;
            }
        }

        return busyDays;
    }
}

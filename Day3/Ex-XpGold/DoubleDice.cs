using System;
using System.Collections.Generic;

class Program
{
    static Random rnd = new Random();

    static int ThrowDice()
    {
        return rnd.Next(1, 7);
    }

    static int ThrowUntilDoubles()
    {
        int count = 0;

        while (true)
        {
            int d1 = ThrowDice();
            int d2 = ThrowDice();
            count++;

            if (d1 == d2)
                return count;
        }
    }

    static void MainSimulation()
    {
        List<int> results = new List<int>();

        for (int i = 0; i < 100; i++)
        {
            int rolls = ThrowUntilDoubles();
            results.Add(rolls);
        }

        int total = 0;
        foreach (var n in results)
            total += n;

        double average = (double)total / results.Count;

        Console.WriteLine($"The total number of throws: {total}");
        Console.WriteLine($"The average number of throws to reach doubles: {average:F2}");
    }

    static void Main()
    {
        MainSimulation();
    }
}
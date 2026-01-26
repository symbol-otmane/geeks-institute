using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var family = new Dictionary<string, int>
        {
            {"rick", 43}, {"beth", 13}, {"morty", 5}, {"summer", 8}
        };

        int total = 0;

        foreach (var member in family)
        {
            int cost = 0;
            if (member.Value < 3) cost = 0;
            else if (member.Value <= 12) cost = 10;
            else cost = 15;

            Console.WriteLine($"{member.Key} pays ${cost}");
            total += cost;
        }

        Console.WriteLine($"Total family cost: ${total}");
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a season (winter/spring/summer/autumn): ");
        string season = Console.ReadLine().ToLower();

        double temp = GetRandomTemp(season);
         Console.WriteLine($"Temperature: {temp:F1}°C");

        if (temp < 0)
            Console.WriteLine("Brrr! It's freezing!");
        else if (temp <= 15)
            Console.WriteLine("Quite chilly, wear a jacket.");
        else if (temp <= 25)
            Console.WriteLine("Mild weather, enjoy!");
        else
            Console.WriteLine("Hot! Stay hydrated.");
    }

    static double GetRandomTemp(string season)
    {
        Random rnd = new Random();
        int min = -10, max = 40;

        switch (season)
        {
            case "winter": min = -10; max = 16; break;
            case "spring": min = 0; max = 23; break;
            case "summer": min = 16; max = 40; break;
            case "autumn": min = 0; max = 23; break;
            default:
                Console.WriteLine("Unknown season. Using default temperature range.");
                break;
        }

        return rnd.NextDouble() * (max - min) + min;
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> birthdays = new Dictionary<string, string>();

        birthdays.Add("Symbol", "1999/11/18");
        birthdays.Add("MrFall", "2005/05/02");
        birthdays.Add("Brahim", "1995/07/22");
        birthdays.Add("Mohamed", "1999/09/18");
        birthdays.Add("Redaoune", "2000/01/30");

        Console.WriteLine("Available names:");
        foreach (var person in birthdays.Keys)
        {
            Console.WriteLine("- " + person);
        }

        Console.Write("\nEnter a name: ");
        string name = Console.ReadLine();

        if (birthdays.ContainsKey(name))
        {
            Console.WriteLine("\n" + name + "'s birthday is: " + birthdays[name]);
        }
        else
        {
            Console.WriteLine("\nSorry, we do not have the birthday information for " + name + ".");
        }
    }
}

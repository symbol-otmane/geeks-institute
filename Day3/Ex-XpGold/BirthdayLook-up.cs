using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> birthdays = new Dictionary<string, string>
        {
            {"Symbol", "1999/11/18"},
            {"MrFall", "2005/05/02"},
            {"Brahim", "1995/07/22"},
            {"Mohamed", "1999/09/18"},
            {"Redaoune", "2000/01/30"}
        };

        Console.Write("Enter a name: ");
        string name = Console.ReadLine();

        if (birthdays.ContainsKey(name))
        {
            Console.WriteLine($"{name}'s birthday is: {birthdays[name]}");
        }
        else
        {
            Console.WriteLine("Name not found!");
        }
    }
}

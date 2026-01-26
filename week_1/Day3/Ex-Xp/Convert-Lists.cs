using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> keys = new List<string> { "Ten", "Twenty", "Thirty" };
        List<int> values = new List<int> { 10, 20, 30 };

        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        for (int i = 0; i < keys.Count; i++)
        {
            dictionary[keys[i]] = values[i];
        }

        Console.WriteLine("{");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"  \"{kvp.Key}\": {kvp.Value}");
        }
        Console.WriteLine("}");
    }
}

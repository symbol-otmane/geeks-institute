using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        Dictionary<char, List<int>> letterPositions = new Dictionary<char, List<int>>();

        for (int i = 0; i < word.Length; i++)
        {
            char letter = word[i];

            if (!letterPositions.ContainsKey(letter))
            {
                letterPositions[letter] = new List<int>();
            }

            letterPositions[letter].Add(i);
        }

        Console.WriteLine("\nLetter positions:");
        foreach (var kvp in letterPositions)
        {
            Console.WriteLine($"'{kvp.Key}': [{string.Join(", ", kvp.Value)}]");
        }
    }
}
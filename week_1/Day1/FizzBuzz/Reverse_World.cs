using System;

class ReverseWord
{
    static void Main()
    {
        Console.Write("Enter a word to reverse: ");
        string word = Console.ReadLine();

        string output = "";
        for (int k = word.Length - 1; k >= 0; k--)
        {
            output += word[k];
        }

        Console.WriteLine("Reversed: " + output);
    }
}
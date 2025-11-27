using System;

class UniqueChars
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();

        if (string.IsNullOrEmpty(text))
        {
            Console.WriteLine("Nothing entered!");
            return;
        }

        string output = "";
        char lastChar = text[0];
        output += lastChar;

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != lastChar)
            {
                output += text[i];
                lastChar = text[i];
            }
        }

        Console.WriteLine("Unique: " + output);
    }
}
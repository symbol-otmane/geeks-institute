using System;

class SimpleMultiples
{
    static void Main()
    {
        Console.Write("Enter a value: ");
        int value = int.Parse(Console.ReadLine());

        Console.Write("Enter how many times: ");
        int times = int.Parse(Console.ReadLine());

        int[] multiples = new int[times];
        for (int i = 0; i < times; i++)
        {
            multiples[i] = value * (i + 1);
        }

        Console.WriteLine("Multiples:");
        for (int i = 0; i < multiples.Length; i++)
        {
            if (i > 0) Console.Write(", ");
            Console.Write(multiples[i]);
        }
        Console.WriteLine();
    }
}

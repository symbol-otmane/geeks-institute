using System;

class Program
{
    static int SumSequence(int x)
    {
        int term1 = x;
        int term2 = x * 11;
        int term3 = x * 111;
        int term4 = x * 1111;

        return term1 + term2 + term3 + term4;
    }

    static void Main()
    {
        Console.Write("Enter a number X: ");
        int x = int.Parse(Console.ReadLine());

        int result = SumSequence(x);

        Console.WriteLine($"Result = {result}");
    }
}
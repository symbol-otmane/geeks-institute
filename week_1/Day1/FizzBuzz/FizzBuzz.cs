using System;

class FizzBuzz
{
    static void Main()
    {
        Console.Write("Enter a number (1-100): ");
        int inputNum = int.Parse(Console.ReadLine());

        if (inputNum % 3 == 0 && inputNum % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (inputNum % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (inputNum % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(inputNum);
        }
    }
}
    
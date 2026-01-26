using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        Console.Write("Enter a number between 1 and 100: ");
        int userNumber;
        while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 1 || userNumber > 100)
        {
            Console.Write("Invalid input. Enter a number between 1 and 100: ");
        }

        int randomNumber = rnd.Next(1, 101);

        Console.WriteLine($"Random number is: {randomNumber}");

        if (userNumber == randomNumber)
        {
            Console.WriteLine("Success! You guessed the number!");
        }
        else
        {
            Console.WriteLine("Fail! Try again.");
            Console.WriteLine($"Your number: {userNumber}, Random number: {randomNumber}");
        }
    }
}

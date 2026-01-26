using System;

class Triangle
{
    static void Main()
    {
        int height = 5;
        for (int row = 1; row <= height; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

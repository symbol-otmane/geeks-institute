using System;

class Dog
{
    public string Name { get; set; }
    public int Height { get; set; }

    public Dog(string name, int height)
    {
        Name = name;
        Height = height;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} goes woof!");
    }

    public void Jump()
    {
        int jumpHeight = Height * 2;
        Console.WriteLine($"{Name} jumps {jumpHeight} cm high!");
    }
}

class Program
{
    static void Main()
    {
        Dog davidsDog = new Dog("Rex", 50);
        davidsDog.Bark();
        davidsDog.Jump();

        Console.WriteLine();

        Dog sarahsDog = new Dog("Teacup", 20);
        sarahsDog.Bark();
        sarahsDog.Jump();

        Console.WriteLine();

        if (davidsDog.Height > sarahsDog.Height)
            Console.WriteLine($"{davidsDog.Name} is taller.");
        else if (sarahsDog.Height > davidsDog.Height)
            Console.WriteLine($"{sarahsDog.Name} is taller.");
        else
            Console.WriteLine("Both dogs have the same height.");
    }
}
using System;
using System.Collections.Generic;

class Cat
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Cat(string catName, int catAge)
    {
        Name = catName;
        Age = catAge;
    }
}

class Program
{
    static void Main()
    {
        Cat cat1 = new Cat("Luna", 3);
        Cat cat2 = new Cat("Simba", 5);
        Cat cat3 = new Cat("Milo", 2);

        List<Cat> cats = new List<Cat> { cat1, cat2, cat3 };

        Cat oldest = FindOldestCat(cats);

        Console.WriteLine($"The oldest cat is {oldest.Name}, and is {oldest.Age} years old.");
    }

    static Cat FindOldestCat(List<Cat> cats)
    {
        Cat oldest = cats[0];

        foreach (var cat in cats)
        {
            if (cat.Age > oldest.Age)
                oldest = cat;
        }

        return oldest;
    }
}

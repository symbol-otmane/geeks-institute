using System;
using System.Collections.Generic;
using System.Linq;

class Zoo
{
    public string Name { get; set; }
    public List<string> Animals { get; set; }
    public Dictionary<char, List<string>> Groups { get; set; }

    public Zoo(string zooName)
    {
        Name = zooName;
        Animals = new List<string>();
        Groups = new Dictionary<char, List<string>>();
    }

    public void AddAnimal(string newAnimal)
    {
        if (!Animals.Contains(newAnimal))
        {
            Animals.Add(newAnimal);
            Console.WriteLine($"{newAnimal} added to the zoo!");
        }
        else
        {
            Console.WriteLine($"{newAnimal} already exists in the zoo.");
        }
    }

    public void GetAnimals()
    {
        Console.WriteLine("\nAnimals in the zoo:");
        foreach (var animal in Animals)
        {
            Console.WriteLine($"- {animal}");
        }
    }

    public void SellAnimal(string animalSold)
    {
        if (Animals.Contains(animalSold))
        {
            Animals.Remove(animalSold);
            Console.WriteLine($"{animalSold} has been sold.");
        }
        else
        {
            Console.WriteLine($"{animalSold} is not in the zoo.");
        }
    }

    public Dictionary<char, List<string>> SortAnimals()
    {
        Groups.Clear();

        var sorted = Animals.OrderBy(a => a).ToList();

        foreach (var animal in sorted)
        {
            char firstLetter = animal[0];

            if (!Groups.ContainsKey(firstLetter))
                Groups[firstLetter] = new List<string>();

            Groups[firstLetter].Add(animal);
        }

        return Groups;
    }

    public void GetGroups()
    {
        Console.WriteLine("\nAnimal Groups:");
        foreach (var group in Groups)
        {
            Console.WriteLine($"{group.Key}: [{string.Join(", ", group.Value)}]");
        }
    }
}

class Program
{
    static void Main()
    {
        Zoo newYorkZoo = new Zoo("New York Zoo");

        Console.WriteLine("Welcome to the New York Zoo management system!");

        while (true)
        {
            Console.Write("\nChoose an action (add, sell, list, sort, groups, exit): ");
            string action = Console.ReadLine().ToLower();

            if (action == "add")
            {
                Console.Write("Which animal should we add? ");
                string animal = Console.ReadLine();
                newYorkZoo.AddAnimal(animal);
            }
            else if (action == "sell")
            {
                Console.Write("Which animal should we sell? ");
                string animal = Console.ReadLine();
                newYorkZoo.SellAnimal(animal);
            }
            else if (action == "list")
            {
                newYorkZoo.GetAnimals();
            }
            else if (action == "sort")
            {
                newYorkZoo.SortAnimals();
                Console.WriteLine("Animals sorted into groups!");
            }
            else if (action == "groups")
            {
                newYorkZoo.GetGroups();
            }
            else if (action == "exit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Try again.");
            }
        }
    }
}
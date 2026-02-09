using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Sphere s1 = new Sphere(3);
        Sphere s2 = Sphere.FromDiameter(10);

        Console.WriteLine("Sphere 1:");
        Console.WriteLine(s1);

        Console.WriteLine("\nSphere 2:");
        Console.WriteLine(s2);

        Sphere s3 = s1 + s2;
        Console.WriteLine("\nAdded Sphere (s1 + s2):");
        Console.WriteLine(s3);

        Console.WriteLine($"\ns1 > s2 ? {s1 > s2}");
        Console.WriteLine($"s1 == s2 ? {s1 == s2}");

        var spheres = new List<Sphere>() { s1, s2, s3 };

        spheres.Sort();
        Console.WriteLine("\nSorted by radius:");
        spheres.ForEach(s => Console.WriteLine(s));

        spheres.Sort((a, b) => a.Volume.CompareTo(b.Volume));
        Console.WriteLine("\nSorted by volume:");
        spheres.ForEach(s => Console.WriteLine(s));

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

using System;

class Program
{
    static void Main()
    {
        DescribeCity("Reykjavik");
        DescribeCity("Paris", "France");
        DescribeCity("New York", "USA");
    }
    static void DescribeCity(string city, string country = "Iceland")
    {
        Console.WriteLine($"{city} is in {country}.");
    }
}
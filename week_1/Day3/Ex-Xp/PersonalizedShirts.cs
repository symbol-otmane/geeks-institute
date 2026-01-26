using System;

class Program
{
    static void Main()
    {
        MakeShirt();

        MakeShirt("Medium");

        MakeShirt("Small", "Hello C#");

        MakeShirt(text: "Custom Text", size: "XL");
    }

    static void MakeShirt(string size = "Large", string text = "I love C#")
    {
        Console.WriteLine($"The size of the shirt is {size} and the text is '{text}'.");
    }
}

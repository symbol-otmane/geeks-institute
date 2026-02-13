## Practical Exercises C#

**- Exercise 1: The Greeting**
```
using System;

class GreetingApp
{
    static void Main()
    {
        Console.WriteLine("Hello! Enjoy learning C#.");
    }
}
```

**- Exercise 2: Personal Info**
```
using System;

class PersonalInfo
{
    static void Main()
    {
        string name = "otman";
        int age = 26;
        string city = "casablanca";

        Console.WriteLine("My name is " + name + ", I am " + age + " years old and I live in " + city);
    }
}
```

**- Exercise 3: The Calculator**
```
using System;

class SimpleCalculator
{
    static void Main()
    {
        int first = 10;
        int second = 5;
        int total = first + second;

        Console.WriteLine("Sum: " + total);
    }
}
```

**- Exercise 4: The Bouncer (If/Else)**
```
using System;

class BouncerCheck
{
    static void Main()
    {
        int age = 16;

        if (age >= 18)
        {
            Console.WriteLine("Allowed in.");
        }
        else
        {
            Console.WriteLine("Not allowed.");
        }
    }
}
```

**- Exercise 5: The Countdown (Loops)**
```
using System;

class CountdownApp
{
    static void Main()
    {
        int n = 10;

        while (n > 0)
        {
            Console.WriteLine(n);
            n--;
        }

        Console.WriteLine("Go!");
    }
}
```

**- Exercise 6: The Repeater (Functions)**
```
using System;

class Repeater
{
    static void Main()
    {
        PrintHello("Adam");
        PrintHello("Sara");
        PrintHello("John");
    }

    static void PrintHello(string person)
    {
        Console.WriteLine("Hello, " + person + "!");
    }
}
```

**- Exercise 7: Even or Odd?**
```
using System;

class EvenOddChecker
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " is Even");
            }
            else
            {
                Console.WriteLine(i + " is Odd");
            }
        }
    }
}
```

**- Exercise 8: <span style="color:#FFD700;">Temperature Converter</span> Task :**
```
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Temperature in Celsius : ");
        double c = double.Parse(Console.ReadLine());
        double f = c * 9/5 + 32;
        Console.Write("Temperature in Fahrenheit : " + f);
    }
}
```

**- Exercise 9: <span style="color:#FFD700;">Number Swapper</span> Task :**
```
using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.Write("Before Swap: a =" + a + ", b = "+ b);
         Console.Write("\n");

        int temp = a;
        a = b;
        b = temp;

        Console.Write("After Swap : a = " + a + ", b = "+ b);
    }
}
```

**- Exercise 10: <span style="color:#FFD700;">Simple Multiplication Table</span> Task :**
```
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a Number : ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
    }
}
```

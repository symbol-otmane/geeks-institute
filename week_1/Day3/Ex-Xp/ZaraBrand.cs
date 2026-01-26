using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var brand = new Dictionary<string, object>
        {
            {"name", "Zara"},
            {"creation_date", 1975},
            {"creator_name", "Amancio Ortega Gaona"},
            {"type_of_clothes", new List<string>{"men", "women", "children", "home"}},
            {"international_competitors", new List<string>{"Gap", "H&M", "Benetton"}},
            {"number_stores", 7000},
            {"major_color", new Dictionary<string, List<string>>
                {
                    {"France", new List<string>{"blue"}},
                    {"Spain", new List<string>{"red"}},
                    {"US", new List<string>{"pink", "green"}}
                }
            }
        };

        brand["number_stores"] = 2;

        var clothes = (List<string>)brand["type_of_clothes"];
        Console.WriteLine($"Zara sells clothes for: {string.Join(", ", clothes)}");

        brand["country_creation"] = "Spain";

        if (brand.ContainsKey("international_competitors"))
        {
            var competitors = (List<string>)brand["international_competitors"];
            competitors.Add("Desigual");
        }

        brand.Remove("creation_date");

        var lastCompetitor = ((List<string>)brand["international_competitors"]).Last();
        Console.WriteLine($"Last international competitor: {lastCompetitor}");

        var colorsUS = ((Dictionary<string, List<string>>)brand["major_color"])["US"];
        Console.WriteLine($"Major colors in US: {string.Join(", ", colorsUS)}");

        Console.WriteLine($"Number of key-value pairs: {brand.Count}");

        Console.WriteLine("Keys: " + string.Join(", ", brand.Keys));

        var more_on_zara = new Dictionary<string, object>
        {
            {"creation_date", 1975},
            {"number_stores", 10000}
        };

        foreach (var kvp in more_on_zara)
        {
            brand[kvp.Key] = kvp.Value;
        }

        Console.WriteLine($"After merging, number of stores: {brand["number_stores"]} (it got updated to 10000)");
    }
}

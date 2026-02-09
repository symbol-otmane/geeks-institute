using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;

class Program
{
    static string filePath = "transactions.json";
    static List<Transaction> transactions = new List<Transaction>();

    static void Main()
    {
        LoadTransactions();

        while (true)
        {
            Console.WriteLine("\n=== Personal Expense Tracker ===");
            Console.WriteLine("1. Add Transaction");
            Console.WriteLine("2. View Transactions");
            Console.WriteLine("3. Update Transaction");
            Console.WriteLine("4. Delete Transaction");
            Console.WriteLine("5. View Summary");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1": AddTransaction(); break;
                case "2": ViewTransactions(); break;
                case "3": UpdateTransaction(); break;
                case "4": DeleteTransaction(); break;
                case "5": ViewSummary(); break;
                case "6": SaveAndExit(); return;
                default: Console.WriteLine("Invalid option!"); break;
            }
        }
    }

    static void AddTransaction()
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Amount: ");
        decimal amount;
        while (!decimal.TryParse(Console.ReadLine(), out amount))
            Console.Write("Invalid! Enter numeric amount: ");

        Console.Write("Category: ");
        string category = Console.ReadLine();

        Console.Write("Date (yyyy-MM-dd): ");
        DateTime date;
        while (!DateTime.TryParse(Console.ReadLine(), out date))
            Console.Write("Invalid! Enter date (yyyy-MM-dd): ");

        transactions.Add(new Transaction
        {
            Title = title,
            Amount = amount,
            Category = category,
            Date = date
        });

        Console.WriteLine("Transaction added successfully!");
    }

    static void ViewTransactions()
    {
        if (!transactions.Any())
        {
            Console.WriteLine("No transactions found.");
            return;
        }

        foreach (var t in transactions)
            Console.WriteLine(t);
    }

    static void UpdateTransaction()
    {
        Console.Write("Enter Transaction ID to update: ");
        string input = Console.ReadLine();
        var transaction = transactions.FirstOrDefault(t => t.Id.ToString() == input);

        if (transaction == null)
        {
            Console.WriteLine("Transaction not found!");
            return;
        }

        Console.Write($"New Title ({transaction.Title}): ");
        string title = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(title)) transaction.Title = title;

        Console.Write($"New Amount ({transaction.Amount}): ");
        string amountInput = Console.ReadLine();
        if (decimal.TryParse(amountInput, out decimal amount)) transaction.Amount = amount;

        Console.Write($"New Category ({transaction.Category}): ");
        string category = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(category)) transaction.Category = category;

        Console.Write($"New Date ({transaction.Date:yyyy-MM-dd}): ");
        string dateInput = Console.ReadLine();
        if (DateTime.TryParse(dateInput, out DateTime date)) transaction.Date = date;

        Console.WriteLine("Transaction updated successfully!");
    }

    static void DeleteTransaction()
    {
        Console.Write("Enter Transaction ID to delete: ");
        string input = Console.ReadLine();
        var transaction = transactions.FirstOrDefault(t => t.Id.ToString() == input);

        if (transaction == null)
        {
            Console.WriteLine("Transaction not found!");
            return;
        }

        transactions.Remove(transaction);
        Console.WriteLine("Transaction deleted successfully!");
    }

    static void ViewSummary()
    {
        decimal income = transactions.Where(t => t.Amount > 0).Sum(t => t.Amount);
        decimal expense = transactions.Where(t => t.Amount < 0).Sum(t => t.Amount);
        decimal balance = income + expense;

        Console.WriteLine($"\nTotal Income: {income:C}");
        Console.WriteLine($"Total Expenses: {expense:C}");
        Console.WriteLine($"Balance: {balance:C}");

        var categorySummary = transactions
            .GroupBy(t => t.Category)
            .Select(g => new { Category = g.Key, Total = g.Sum(t => t.Amount) });

        Console.WriteLine("\nExpenses per Category:");
        foreach (var cat in categorySummary)
            Console.WriteLine($"{cat.Category}: {cat.Total:C}");
    }

    static void LoadTransactions()
    {
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            transactions = JsonSerializer.Deserialize<List<Transaction>>(json);
        }
    }

    static void SaveAndExit()
    {
        var json = JsonSerializer.Serialize(transactions, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
        Console.WriteLine("Transactions saved. Goodbye!");
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static List<Task> tasks = new List<Task>();
    static string dataFile = "tasks.json";

    static void Main()
    {
        LoadTasks();
        while (true)
        {
            Console.WriteLine("\n=== Personal Task Manager ===");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Update Task Status");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Edit Task");
            Console.WriteLine("6. Search Tasks");
            Console.WriteLine("7. Sort Tasks");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1": AddTask(); break;
                case "2": ViewTasks(); break;
                case "3": UpdateTaskStatus(); break;
                case "4": DeleteTask(); break;
                case "5": EditTask(); break;
                case "6": SearchTasks(); break;
                case "7": SortTasks(); break;
                case "8": SaveTasks(); return;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Enter title: ");
        string title = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter due date (yyyy-mm-dd, optional): ");
        string dateInput = Console.ReadLine();
        DateTime? dueDate = string.IsNullOrWhiteSpace(dateInput) ? null : DateTime.Parse(dateInput);

        tasks.Add(new Task(title, description, dueDate));
        Console.WriteLine("Task added successfully!");
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"\nTask {i+1}:");
            Console.WriteLine(tasks[i]);
        }
    }

    static void UpdateTaskStatus()
    {
        ViewTasks();
        Console.Write("Enter task number to update: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            Task t = tasks[index - 1];
            t.Status = t.Status == "Pending" ? "Completed" : "Pending";
            Console.WriteLine("Task status updated!");
        }
        else
            Console.WriteLine("Invalid task number.");
    }

    static void DeleteTask()
    {
        ViewTasks();
        Console.Write("Enter task number to delete: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            tasks.RemoveAt(index - 1);
            Console.WriteLine("Task deleted!");
        }
        else
            Console.WriteLine("Invalid task number.");
    }

    static void EditTask()
    {
        ViewTasks();
        Console.Write("Enter task number to edit: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            Task t = tasks[index - 1];
            Console.Write("Enter new title (leave blank to keep current): ");
            string title = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(title)) t.Title = title;

            Console.Write("Enter new description (leave blank to keep current): ");
            string desc = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(desc)) t.Description = desc;

            Console.Write("Enter new due date (yyyy-mm-dd, leave blank to keep current): ");
            string dateInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(dateInput)) t.DueDate = DateTime.Parse(dateInput);

            Console.WriteLine("Task updated successfully!");
        }
        else
            Console.WriteLine("Invalid task number.");
    }

    static void SearchTasks()
    {
        Console.Write("Enter keyword to search: ");
        string keyword = Console.ReadLine().ToLower();
        var results = tasks.FindAll(t => t.Title.ToLower().Contains(keyword) || t.Description.ToLower().Contains(keyword));
        if (results.Count == 0) Console.WriteLine("No tasks found.");
        else results.ForEach(t => Console.WriteLine(t));
    }

    static void SortTasks()
    {
        tasks.Sort((x, y) => string.Compare(x.Status, y.Status));
        Console.WriteLine("Tasks sorted by status.");
    }

    static void SaveTasks()
    {
        string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(dataFile, json);
        Console.WriteLine("Tasks saved. Goodbye!");
    }

    static void LoadTasks()
    {
        if (File.Exists(dataFile))
        {
            string json = File.ReadAllText(dataFile);
            tasks = JsonSerializer.Deserialize<List<Task>>(json);
        }
    }
}

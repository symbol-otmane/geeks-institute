using System;

public class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; } = "Pending";
    public DateTime? DueDate { get; set; }

    public Task(string title, string description, DateTime? dueDate = null)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
    }

    public override string ToString()
    {
        string dueDateStr = DueDate.HasValue ? DueDate.Value.ToString("yyyy-MM-dd") : "N/A";
        return $"Title: {Title}\nDescription: {Description}\nStatus: {Status}\nDue Date: {dueDateStr}";
    }
}

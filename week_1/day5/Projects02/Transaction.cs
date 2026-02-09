using System;

public class Transaction
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }
    public DateTime Date { get; set; }

    public override string ToString()
    {
        string type = Amount >= 0 ? "Income " : "Expense";
        return $"{Id} | {Title} | {Amount:C} | {Category} | {Date:yyyy-MM-dd} | {type}";
    }
}
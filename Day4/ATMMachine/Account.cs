using System;
using System.Collections.Generic;

namespace ATMApp
{
    public class Account
    {
        public string AccountNumber { get; private set; }
        public int PIN { get; private set; }
        public double Balance { get; private set; }
        public List<string> Transactions { get; private set; }

        public Account(string accountNumber, int pin, double balance)
        {
            AccountNumber = accountNumber;
            PIN = pin;
            Balance = balance;
            Transactions = new List<string>();
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: ${Balance:F2}");
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive. Try again!");
                return;
            }
            Balance += amount;
            Transactions.Add($"Deposit: ${amount:F2}");
            Console.WriteLine($"Success! You deposited ${amount:F2}. New balance: ${Balance:F2}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive!");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds!");
                return;
            }

            Balance -= amount;
            Transactions.Add($"Withdrawal: ${amount:F2}");
            Console.WriteLine($"Withdrawal successful! New balance: ${Balance:F2}");
        }

        public void ShowTransactions()
        {
            Console.WriteLine("\nTransaction History:");
            if (Transactions.Count == 0)
            {
                Console.WriteLine("No transactions available.");
                return;
            }

            foreach (var t in Transactions)
            {
                Console.WriteLine(t);
            }
        }
    }
}

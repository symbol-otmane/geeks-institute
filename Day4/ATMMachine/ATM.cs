using System;
using System.Collections.Generic;

namespace ATMApp
{
    public class ATM
    {
        private Dictionary<string, Account> Accounts;

        public ATM(Dictionary<string, Account> accounts)
        {
            Accounts = accounts;
        }

        public Account Authenticate()
        {
            Console.Write("Enter account number: ");
            string accNumber = Console.ReadLine();

            if (!Accounts.ContainsKey(accNumber))
            {
                Console.WriteLine("Account not found.");
                return null;
            }

            int attempts = 0;
            while (attempts < 3)
            {
                Console.Write("Enter your PIN: ");
                if (int.TryParse(Console.ReadLine(), out int pin))
                {
                    if (Accounts[accNumber].PIN == pin)
                    {
                        Console.WriteLine("Access granted!\n");
                        return Accounts[accNumber];
                    }
                    else
                    {
                        Console.WriteLine("Incorrect PIN. Try again.");
                        attempts++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Numbers only.");
                }
            }

            Console.WriteLine("Too many incorrect attempts. Exiting...");
            return null;
        }

        public void ShowMenu()
        {
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. View Transactions");
           Console.WriteLine("5. Exit");
        }

        public bool PerformAction(Account account, string choice)
        {
            switch (choice)
            {
                case "1":
                    account.CheckBalance();
                    break;
                case "2":
                    Console.Write("Enter deposit amount: ");
                    if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        account.Deposit(depositAmount);
                    else
                        Console.WriteLine("Invalid amount.");
                    break;
                case "3":
                    Console.Write("Enter withdrawal amount: ");
                    if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        account.Withdraw(withdrawAmount);
                    else
                        Console.WriteLine("Invalid amount.");
                    break;
                case "4":
                    account.ShowTransactions();
                    break;
                case "5":
                    Console.WriteLine("Exiting the ATM...");
                    return false;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            return true;
        }
    }
}

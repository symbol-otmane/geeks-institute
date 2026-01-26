using System;
using System.Collections.Generic;

namespace ATMApp
{
    class Program
    {
        static void Main()
        {
            var accounts = new Dictionary<string, Account>
            {
                { "12345", new Account("12345", 1111, 1000) },
                { "67890", new Account("67890", 2222, 2000) },
                { "54321", new Account("54321", 3333, 500) }
            };

            ATM atm = new ATM(accounts);

            Console.WriteLine("Welcome to the ATM Machine!");

            Account currentAccount = atm.Authenticate();
            if (currentAccount == null)
                return;

            bool continueRunning = true;
            while (continueRunning)
            {
                atm.ShowMenu();
                Console.Write("What would you like to do? (Enter option number): ");
                string choice = Console.ReadLine();
                continueRunning = atm.PerformAction(currentAccount, choice);
            }

            Console.WriteLine("\nThank you for using the ATM. Here is your transaction summary:");
            currentAccount.ShowTransactions();
        }
    }
}

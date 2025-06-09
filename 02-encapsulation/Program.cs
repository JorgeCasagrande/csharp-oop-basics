using System;

namespace Encapsulation
{
    public class BankAccount
    {
        // Private field (internal state)
        private decimal balance;

        // Public property to read balance (read-only)
        public decimal Balance
        {
            get { return balance; }
        }

        // Method to safely modify the balance
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit must be a positive amount.");
                return;
            }

            balance += amount;
            Console.WriteLine($"Deposited: {amount}. New balance: {balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            // Accessing balance through property
            Console.WriteLine($"Initial balance: {account.Balance}");

            // Trying a valid deposit
            account.Deposit(100m);

            // Trying an invalid deposit
            account.Deposit(-50m);

            // Final balance
            Console.WriteLine($"Final balance: {account.Balance}");
        }
    }
}
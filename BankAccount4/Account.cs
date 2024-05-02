﻿using System;

namespace BankAccount4
{
    // Define a class named Account
    public class Account
    {
        // Private fields to store account balance and name
        private decimal _balance;
        private string _name;

        // Constructor to initialize account with name and initial balance
        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        // Public property to get account name (read-only)
        public string Name
        {
            get { return _name; }
        }

        // Method to withdraw amount from account
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount to withdraw.");
                return false;
            }
            else if (amount > _balance)
            {
                Console.WriteLine($"Insufficient funds. Your Balance is {_balance}");
                return false;
            }

            _balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
            Console.WriteLine($"Remaining Balance: {_balance}");

            return true;
        }

        // Method to deposit amount into account
        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount to deposit.");
                return false;
            }

            _balance += amount;
            Console.WriteLine($"Deposited: {amount}");
            Console.WriteLine($"New Balance: {_balance}");
            return true;
        }

        // Method to print account details
        public void Print()
        {
            Console.WriteLine($"Account Name: {_name}");
            Console.WriteLine($"Balance: {_balance}");
        }
    }
}

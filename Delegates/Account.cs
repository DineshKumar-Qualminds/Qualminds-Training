using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegates
    {
        // Creating Delegate
        public delegate void TransactionAction(Account acc, decimal amount);

        // Account class
        public class Account
        {
            public string AccountNumber { get; set; }
            public decimal Balance { get; set; }

            public Account(string accountNumber, decimal balance)
            {
                AccountNumber = accountNumber;
                Balance = balance;
            }

            public void PrintBalance()
            {
                Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance}");
            }

            public void Deposit(decimal amount)
            {
                Balance += amount;
                Console.WriteLine($"Deposited : {amount}. New balance: {Balance}");
            }

            public void Withdraw(decimal amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrawn : {amount}. New balance: {Balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
        }

        // Bank class
        public class Bank
        {
            public void PerformTransaction(Account acc, decimal amount, TransactionAction action)
            {
                action(acc, amount);
            }
        }

        class BankAccount
        {
            static void Main(string[] args)
            {
                Account acc = new Account("647656298", 10000);
                Bank bank = new Bank();

                TransactionAction depositAction = (account, amount) => account.Deposit(amount);
                TransactionAction withdrawAction = (account, amount) => account.Withdraw(amount);

                Console.WriteLine("Initial Account Details:");
                acc.PrintBalance();

                bank.PerformTransaction(acc, 500, depositAction);
                bank.PerformTransaction(acc, 200, withdrawAction);

                Console.WriteLine("Final Account Details:");
                acc.PrintBalance();

                Console.ReadKey();
            }
        }
    }



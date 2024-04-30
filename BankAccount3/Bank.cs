using System;
using System.Collections.Generic;

namespace BankAccount3
{
    // Define a class named Bank
    public class Bank
    {
        // Private field to store a list of accounts
        private List<Account> _accounts;

        // Constructor to initialize the list of accounts
        public Bank()
        {
            _accounts = new List<Account>();
        }

        // Method to add an account to the list
        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        // Method to get an account by name from the list
        public Account GetAccount(string name)
        {
            foreach (var account in _accounts)
            {
                if (account.Name == name)
                {
                    return account;
                }
            }
            return null; // Return null if account not found
        }

        // Method to execute a withdrawal transaction
        public void ExecuteTransaction(WithdrawTransaction transaction)
        {
            transaction.Execute();
        }

        // Method to execute a deposit transaction
        public void ExecuteTransaction(DepositTransaction transaction)
        {
            transaction.Execute();
        }

        // Method to execute a transfer transaction
        public void ExecuteTransaction(TransferTransaction transaction)
        {
            transaction.Execute();
        }
    }
}

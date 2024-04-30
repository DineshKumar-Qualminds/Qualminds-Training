using System;

namespace BankAccount3
{
    // Define a class named DepositTransaction
    public class DepositTransaction
    {
        // Private fields to store account and amount
        private Account _account;
        private decimal _amount;
        private bool _executed = false; // Flag to track if the transaction has been executed
        private bool _success = false; // Flag to track if the transaction was successful

        // Public property to get the success status of the transaction
        public bool Success
        {
            get { return _success; }
        }

        // Constructor to initialize the account and amount
        public DepositTransaction(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        // Method to execute the deposit transaction
        public void Execute()
        {
            // Check if the transaction has already been executed
            if (_executed)
            {
                throw new InvalidOperationException("Cannot execute this transaction as it has already been executed.");
            }

            // Mark the transaction as executed
            _executed = true;

            // Execute the deposit operation on the account
            _success = _account.Deposit(_amount);
        }

        // Method to rollback the deposit transaction
        public void Rollback()
        {
            // Check if the transaction has been executed
            if (!_executed)
            {
                throw new InvalidOperationException("Cannot rollback this transaction as it has not been executed.");
            }

            // If the deposit was successful, rollback by withdrawing the amount
            if (_success)
            {
                _account.Withdraw(_amount);
            }
        }

        // Method to print the details of the deposit transaction
        public void Print()
        {
            Console.WriteLine("Deposit Transaction Details:");
            Console.WriteLine($"Amount: {_amount}");
            Console.WriteLine($"Successful: {_success}");
        }
    }
}

using System;

namespace BankAccount3
{
    // Define a class named WithdrawTransaction
    public class WithdrawTransaction
    {
        // Private fields to store information about the transaction
        private Account _account;
        private decimal _amount;
        private bool _executed = false;
        private bool _success = false;

        // Property to get whether the transaction was successful
        public bool Success
        {
            get { return _success; }
        }

        // Constructor to initialize the WithdrawTransaction object
        public WithdrawTransaction(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        // Method to execute the withdrawal transaction
        public void Execute()
        {
            if (_executed)
            {
                throw new InvalidOperationException("Cannot execute this transaction as it has already been executed.");
            }

            _executed = true;
            _success = _account.Withdraw(_amount);
        }

        // Method to rollback the transaction
        public void Rollback()
        {
            if (!_executed)
            {
                throw new InvalidOperationException("Cannot rollback this transaction as it has not been executed.");
            }

            if (_success)
            {
                _account.Deposit(_amount);
            }
        }

        // Method to print details of the withdrawal transaction
        public void Print()
        {
            Console.WriteLine("Withdraw Transaction Details:");
            Console.WriteLine($"Amount: {_amount}");
            Console.WriteLine($"Successful: {_success}");
        }
    }
}

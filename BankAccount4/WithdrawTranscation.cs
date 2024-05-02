using System;

namespace BankAccount4
{
    // Define a class named WithdrawTransaction that inherits from Transaction
    public class WithdrawTransaction : Transaction
    {
        private Account account; // Field to store the account from which the amount is withdrawn

        // Constructor to initialize the WithdrawTransaction object
        public WithdrawTransaction(Account account, decimal amount) : base(amount)
        {
            this.account = account;
        }

        // Method to print details of the withdraw transaction
        public override void Print()
        {
            Console.WriteLine("Withdraw Transaction Details:");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Successful: {Success}");
        }

        // Method to execute the withdraw transaction
        public override void Execute()
        {
            base.Execute(); // Call the base class method to mark the transaction as executed
            success = account.Withdraw(amount); // Withdraw the amount from the account and store the success status
        }

        // Method to rollback the transaction
        public override void Rollback()
        {
            base.Rollback(); // Call the base class method to mark the transaction as reversed
            if (success)
            {
                account.Deposit(amount); // Deposit the amount back to the account if the withdrawal was successful
            }
        }
    }
}

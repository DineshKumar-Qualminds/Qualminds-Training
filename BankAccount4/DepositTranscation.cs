using System;

namespace BankAccount4
{
    // Define a class named DepositTransaction that inherits from Transaction
    public class DepositTransaction : Transaction
    {
        private Account account;

        // Constructor to initialize a DepositTransaction object with an account and amount
        public DepositTransaction(Account account, decimal amount) : base(amount)
        {
            this.account = account;
        }

        // Method to print details of the deposit transaction
        public override void Print()
        {
            Console.WriteLine("Deposit Transaction Details:");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Successful: {Success}");
        }

        // Method to execute the deposit transaction
        public override void Execute()
        {
            base.Execute(); // Execute base class logic
            success = account.Deposit(amount); // Deposit amount into the account
        }

        // Method to rollback the deposit transaction
        public override void Rollback()
        {
            base.Rollback(); // Execute base class logic
            if (success)
            {
                account.Withdraw(amount); // Withdraw the deposited amount if the deposit was successful
            }
        }
    }
}

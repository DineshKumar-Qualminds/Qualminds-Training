using System;

namespace BankAccount4
{
    // Define a class named TransferTransaction that inherits from Transaction
    public class TransferTransaction : Transaction
    {
        private Account _fromAccount; // Field to store the account from which the amount is transferred
        private Account _toAccount; // Field to store the account to which the amount is transferred
        private decimal _amount; // Field to store the amount transferred

        // Constructor to initialize the TransferTransaction object
        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount) : base(amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;
        }

        // Method to execute the transfer transaction
        public override void Execute()
        {
            // Check if the transaction has already been executed
            if (Executed)
            {
                throw new InvalidOperationException("Transaction has already been executed.");
            }

            base.Execute(); // Call the base class method to mark the transaction as executed

            // Withdraw the amount from the sender's account
            bool withdrawSuccess = _fromAccount.Withdraw(_amount);
            if (!withdrawSuccess)
            {
                throw new InvalidOperationException("Withdrawal failed, transaction aborted.");
            }

            // Deposit the amount into the recipient's account
            bool depositSuccess = _toAccount.Deposit(_amount);
            if (!depositSuccess)
            {
                // Rollback the withdrawal if deposit fails
                _fromAccount.Deposit(_amount);
                throw new InvalidOperationException("Deposit failed, transaction aborted.");
            }
        }

        // Method to rollback the transaction
        public override void Rollback()
        {
            // Check if the transaction has been executed
            if (!Executed)
            {
                throw new InvalidOperationException("Cannot rollback transaction that has not been executed.");
            }

            base.Rollback(); // Call the base class method to mark the transaction as reversed

            // Deposit the amount back to the sender's account
            bool withdrawSuccess = _fromAccount.Deposit(_amount);
            if (!withdrawSuccess)
            {
                throw new InvalidOperationException("Rollback failed for withdrawal.");
            }

            // Withdraw the amount from the recipient's account
            bool depositSuccess = _toAccount.Withdraw(_amount);
            if (!depositSuccess)
            {
                throw new InvalidOperationException("Rollback failed for deposit.");
            }
        }

        // Method to print details of the transfer transaction
        public override void Print()
        {
            Console.WriteLine($"Transferred {_amount} from {_fromAccount.Name}'s Account to {_toAccount.Name}'s Account");
        }
    }
}

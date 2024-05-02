using System;

namespace BankAccount4
{
    // Define an abstract class named Transaction
    public abstract class Transaction
    {
        protected decimal amount; // Field to store the transaction amount
        private DateTime dateStamp; // Field to store the date and time of the transaction
        protected bool executed = false; // Flag to indicate if the transaction has been executed
        protected bool reversed = false; // Flag to indicate if the transaction has been reversed
        protected bool success = false; // Flag to indicate if the transaction was successful

        // Properties to access the transaction status and datestamp
        public bool Executed => executed;
        public bool Success => success;
        public DateTime DateStamp => dateStamp;

        // Constructor to initialize the amount field
        public Transaction(decimal amount)
        {
            this.amount = amount;
        }

        // Abstract method to print transaction details (to be implemented by derived classes)
        public abstract void Print();

        // Virtual method to execute the transaction
        public virtual void Execute()
        {
            if (executed)
            {
                throw new InvalidOperationException("Transaction has already been executed.");
            }

            executed = true;
            dateStamp = DateTime.Now; // Record the current date and time
        }

        // Virtual method to rollback the transaction
        public virtual void Rollback()
        {
            if (!executed)
            {
                throw new InvalidOperationException("Cannot rollback transaction that has not been executed.");
            }

            reversed = true; // Mark the transaction as reversed
        }
    }

}

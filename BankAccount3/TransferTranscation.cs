using System;

namespace BankAccount3
{
    // Define a class named TransferTransaction
    public class TransferTransaction
    {
        // Private fields to store information about the transaction
        private Account _fromAccount;
        private Account _toAccount;
        private decimal _amount;
        private DepositTransaction _depositTransaction;
        private WithdrawTransaction _withdrawTransaction;
        private bool _executed = false;
        private bool _reversed = false;

        // Constructor to initialize the TransferTransaction object
        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;
            _withdrawTransaction = new WithdrawTransaction(fromAccount, amount);
            _depositTransaction = new DepositTransaction(toAccount, amount);
        }

        // Property to get whether the transaction has been executed
        public bool Executed => _executed;

        // Property to get whether the transaction was successful
        public bool Success => _withdrawTransaction.Success && _depositTransaction.Success;

        // Property to get whether the transaction has been reversed
        public bool Reversed => _reversed;

        // Method to execute the transfer transaction
        public void Execute()
        {
            if (_executed)
            {
                throw new InvalidOperationException("Transaction has already been executed.");
            }

            _executed = true;

            try
            {
                _withdrawTransaction.Execute();

                if (_withdrawTransaction.Success)
                {
                    _depositTransaction.Execute();
                }
                else
                {
                    throw new InvalidOperationException("Withdrawal was not successful, transfer cannot be completed.");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error during transfer: {ex.Message}");
                Rollback();
            }
        }

        // Method to rollback the transaction
        public void Rollback()
        {
            if (!_executed)
            {
                throw new InvalidOperationException("Cannot rollback transaction that has not been executed.");
            }

            if (_reversed)
            {
                throw new InvalidOperationException("Transaction has already been reversed.");
            }

            if (_withdrawTransaction.Success)
            {
                _withdrawTransaction.Rollback();
            }

            if (_depositTransaction.Success)
            {
                _depositTransaction.Rollback();
            }

            _reversed = true;
        }

        // Method to print details of the transfer transaction
        public void Print()
        {
            Console.WriteLine($"Transferred {_amount:C} from {_fromAccount.Name}'s Account to {_toAccount.Name}'s Account");
            Console.WriteLine("Withdraw Transaction Details:");
            _withdrawTransaction.Print();
            Console.WriteLine();
            Console.WriteLine("Deposit Transaction Details:");
            _depositTransaction.Print();
        }
    }
}

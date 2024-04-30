using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount2
{
    public class TransferTransaction
    {
        private Account _fromAccount;
        private Account _toAccount;
        private decimal _amount;
        private DepositTransaction _depositTransaction;
        private WithdrawTransaction _withdrawTransaction;
        private bool _executed = false;
        private bool _reversed = false;

        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;
            _withdrawTransaction = new WithdrawTransaction(fromAccount, amount);
            _depositTransaction = new DepositTransaction(toAccount, amount);
        }

        public bool Executed => _executed;

        public bool Success => _withdrawTransaction.Success && _depositTransaction.Success;

        public bool Reversed => _reversed;

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

        public void Print()
        {
            Console.WriteLine($"Transferred {_amount} from {_fromAccount.Name}'s Account to {_toAccount.Name}'s Account");
            Console.WriteLine("Withdraw Transaction Details:");
            _withdrawTransaction.Print();
            Console.WriteLine();
            Console.WriteLine("Deposit Transaction Details:");
            _depositTransaction.Print();
        }
    }

}

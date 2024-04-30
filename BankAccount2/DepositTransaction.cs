using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount2
{
    public class DepositTransaction
    {
        private Account _account;
        private decimal _amount;
        private bool _executed = false;
        private bool _success = false;

        public bool Success
        {
            get { return _success; }
        }

        public DepositTransaction(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        public void Execute()
        {
            if (_executed)
            {
                throw new InvalidOperationException("Cannot execute this transaction as it has already been executed.");
            }

            _executed = true;
            _success = _account.Deposit(_amount);
        }

        public void Rollback()
        {
            if (!_executed)
            {
                throw new InvalidOperationException("Cannot rollback this transaction as it has not been executed.");
            }

            if (_success)
            {
                _account.Withdraw(_amount);
            }
        }

        public void Print()
        {
            Console.WriteLine("Deposit Transaction Details:");
            Console.WriteLine($"Amount: {_amount}");
            Console.WriteLine($"Successful: {_success}");
        }
    }

}

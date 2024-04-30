using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DineshKumar_CSharp101
{
    public class FixedDepositAccount : IAccount
    {
        public event EventHandler<BalanceChangedEventArgs> BalanceChanged;

        private decimal _balance;
        private bool _withdrawn;
        private bool _deposited;

        public FixedDepositAccount(decimal initialBalance)
        {
            _balance = initialBalance;
            _withdrawn = false;
            _deposited = false;
        }

        public decimal Balance => _balance;

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount cannot be zero or negative.");
            }

      
                if (_deposited)
                {
                    throw new InvalidOperationException("Only one deposit allowed for Fixed Deposit account.");
                }

            _balance += amount;
            _deposited = true;
            OnBalanceChanged(new BalanceChangedEventArgs(_balance));
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount cannot be zero or negative.");
            }

            if (_withdrawn)
            {
                throw new InvalidOperationException("Only one withdrawal allowed for Fixed Deposit account.");
            }

            _balance -= amount;
            _withdrawn = true;
            OnBalanceChanged(new BalanceChangedEventArgs(_balance));
            return true;
        }

        protected virtual void OnBalanceChanged(BalanceChangedEventArgs e)
        {
            BalanceChanged?.Invoke(this, e);
        }
    }

}

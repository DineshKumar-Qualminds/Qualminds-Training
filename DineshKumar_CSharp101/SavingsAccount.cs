using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshKumar_CSharp101
{
    public class SavingsAccount : IAccount
    {
        public event EventHandler<BalanceChangedEventArgs> BalanceChanged;

        private decimal _balance;
        private const int MaxTransactions = 5;
        private const decimal MaxTransactionAmount = 50000;
        private int _transactionCount = 0;

        public SavingsAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        public decimal Balance => _balance;

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount cannot be zero or negative.");
            }

            _balance += amount;
            OnBalanceChanged(new BalanceChangedEventArgs(_balance));
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount cannot be zero or negative.");
            }

            if (_transactionCount >= MaxTransactions)
            {
                throw new InvalidOperationException("Maximum number of transactions reached for this month.");
            }
            if (amount > MaxTransactionAmount) 
            {
                throw new InvalidOperationException("MaxTransactionAmount limit is only 50000");
            }

            if (_balance - amount < 1000)
            {
                throw new InvalidOperationException("Insufficient funds. Minimum balance of 1000 INR required.");
            }

            _balance -= amount;
            _transactionCount++;
            OnBalanceChanged(new BalanceChangedEventArgs(_balance));
            return true;
        }


        protected virtual void OnBalanceChanged(BalanceChangedEventArgs e)
        {
            BalanceChanged?.Invoke(this, e);
        }
    }

}

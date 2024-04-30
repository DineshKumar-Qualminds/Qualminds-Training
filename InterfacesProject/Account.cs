using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesProject
{
    public abstract class Account : IAccount
    {
        public double Balance { get; set; }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);

        public virtual void Transfer(double amount, IAccount destinationAccount)
        {
            if (Balance >= amount)
            {
                Withdraw(amount);
                destinationAccount.Deposit(amount);
                Console.WriteLine($"Transferred {amount} to destination account.");
            }
            else
            {
                Console.WriteLine("Insufficient Funds for transfer.");
            }
        }

        public void PrintAmount()
        {
            Console.WriteLine($"Available Balance : {Balance}");
        }

    }
}

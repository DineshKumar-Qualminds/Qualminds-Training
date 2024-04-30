using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesProject
{
    public class CurrentAccount : Account
    {
        public override void Deposit(double amount)
        {
            Balance += amount;

        }
        public override void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }

        }


        public override void Transfer(double amount, IAccount destinationAccount)
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
            Console.WriteLine($"CurrentAccount Available Balance : {Balance}");
        }

    }
}

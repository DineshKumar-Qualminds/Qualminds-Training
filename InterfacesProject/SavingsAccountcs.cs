using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesProject
{
    public class SavingsAccount : Account
    {
        double interestRate;

        public SavingsAccount(double initialBalance, double interestRate)
        {
            Balance = initialBalance;
            this.interestRate = interestRate;
        }

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
       


        public void AddInterest()
        {
            double InterestAmount = Balance * interestRate / 100;
            Balance += InterestAmount;
            Console.WriteLine($"Interest Earned : {InterestAmount}");
        }
        public void PrintAmount()
        {
            Console.WriteLine($"Savings Account Available Balance : {Balance}"); 

        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesProject
{
    public interface IAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        void Transfer(double amount, IAccount destinationAccount);
        void PrintAmount();
    }
}

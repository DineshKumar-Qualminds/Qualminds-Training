using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshKumar_CSharp101
{
 
    public interface IAccount
    {
        decimal Balance { get; }
        bool Deposit(decimal amount);
        bool Withdraw(decimal amount);
        event EventHandler<BalanceChangedEventArgs> BalanceChanged;
    }

}

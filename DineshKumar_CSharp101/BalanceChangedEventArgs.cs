using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshKumar_CSharp101
{
    public class BalanceChangedEventArgs : EventArgs
    {
        public decimal NewBalance { get; private set; }

        public BalanceChangedEventArgs(decimal newBalance)
        {
            NewBalance = newBalance;
        }
    }
}

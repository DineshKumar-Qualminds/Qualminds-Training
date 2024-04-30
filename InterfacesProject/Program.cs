using System;

namespace InterfacesProject
{
    
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount account = new SavingsAccount(2000,2.5);
            account.Deposit(1000);
            account.Withdraw(100);
            account.AddInterest();  
            account.PrintAmount();
            Console.WriteLine();

            CurrentAccount currentAccount = new CurrentAccount();
            currentAccount.Deposit(2000);
            currentAccount.Withdraw(200);
            currentAccount.PrintAmount();

            CurrentAccount currentAccount1 = new CurrentAccount();
            currentAccount1.Deposit(1000);
            currentAccount1.Transfer(100, currentAccount); 
            currentAccount1.PrintAmount();
            currentAccount1.PrintAmount();

        }
    }
}

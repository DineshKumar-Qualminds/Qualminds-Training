using System;
using System.Security.Principal;


namespace DineshKumar_CSharp101
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAccount account;
            string accountType;

            Console.WriteLine("Welcome to XYZ Bank!");
            //Choose Account Type
            Console.WriteLine("Choose account type (Savings/FD):");
            accountType = Console.ReadLine().ToLower();

            if (accountType == "savings")
            {
                account = new SavingsAccount(1000);
            }
            else if (accountType == "fd")
            {
                account = new FixedDepositAccount(5000);
            }
            else
            {
                Console.WriteLine("Invalid account type. Exiting...");
                return;
            }

            account.BalanceChanged += OnBalanceChanged;

            // Menu loop for transactions
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Deposit(account);
                        break;
                    case "2":
                        Withdraw(account);
                        break;
                    case "3":
                        Console.WriteLine($"Current Balance: {account.Balance}");
                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        //Deposit Amount
        private static void Deposit(IAccount account)
        {
            decimal amount;

            Console.WriteLine("Enter deposit amount:");
            while (!decimal.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid amount. Please enter a number.");
            }

            try
            {
                if (account.Deposit(amount))
                {
                    Console.WriteLine("Deposit successful!");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //WithDraw Amount
        private static void Withdraw(IAccount account)
        {
            decimal amount;

            Console.WriteLine("Enter withdrawal amount:");
            while (!decimal.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid amount. Please enter a number.");
            }

            try
            {
                if (account.Withdraw(amount))
                {
                    Console.WriteLine("Withdrawal successful!");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private static void OnBalanceChanged(object sender, BalanceChangedEventArgs e)
        {
            Console.WriteLine($"Balance changed: New balance is {e.NewBalance}");
        }
    }
}
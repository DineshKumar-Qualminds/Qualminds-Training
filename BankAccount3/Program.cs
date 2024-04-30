using System;


namespace BankAccount3
{
    // Define a class named Program
    public class Program
    {
        // Create a new Bank object to manage accounts
        private static Bank _bank = new Bank();

        // Enum to represent different menu options
        private enum MenuOption
        {
            NewAccount = 1,
            Withdraw,
            Deposit,
            Transfer,
            Print,
            Quit
        }

        // Method to read user's menu option choice
        private static MenuOption ReadUserOption()
        {
            int selection;
            do
            {
                // Display menu options
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. New Account");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Print");
                Console.WriteLine("6. Quit");
                Console.Write("Enter your choice: ");
                
                if (!int.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }
            } while (selection < 1 || selection > 6);

            return (MenuOption)selection;
        }

        // Main method, entry point of the program
        private static void Main()
        {
            MenuOption option;
            do
            {
                // Read user's menu option choice
                option = ReadUserOption();
                // Execute the selected menu option
                switch (option)
                {
                    case MenuOption.NewAccount:
                        CreateNewAccount();
                        break;
                    case MenuOption.Withdraw:
                        DoWithdraw();
                        break;
                    case MenuOption.Deposit:
                        DoDeposit();
                        break;
                    case MenuOption.Transfer:
                        DoTransfer();
                        break;
                    case MenuOption.Print:
                        PrintAccount();
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Exiting program.");
                        break;
                }
            } while (option != MenuOption.Quit);
        }

        // Method to create a new account and add it to the bank
        private static void CreateNewAccount()
        {
            Console.Write("Enter account holder's name: ");
            string accountHolderName = Console.ReadLine();

            
            decimal initialBalance;
            do
            {
                Console.Write("Enter initial Balance: ");
                if(!decimal.TryParse(Console.ReadLine(), out initialBalance))
                {
                    Console.WriteLine("Invalid Input, Please enter a valid number");
                    
                }

            } while (initialBalance == 0);

         
            Account account = new Account(accountHolderName, initialBalance);

            _bank.AddAccount(account);
        }

        // Method to withdraw money from an account
        private static void DoWithdraw()
        {
            Console.Write("Enter account holder's name: ");
            string accountHolderName = Console.ReadLine();
            Account account = _bank.GetAccount(accountHolderName);

            if (account == null)
            {
                Console.WriteLine($"No account found with name {accountHolderName}");
                return;
            }

          
            decimal amount;
            do
            {
                Console.Write("Enter amount to withdraw: ");
                if (!decimal.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number.");
                }

            } while (amount == 0);


            WithdrawTransaction transaction = new WithdrawTransaction(account, amount);
            _bank.ExecuteTransaction(transaction);
        }

        // Method to deposit money into an account
        private static void DoDeposit()
        {
            Console.Write("Enter account holder's name: ");
            string accountHolderName = Console.ReadLine();
            Account account = _bank.GetAccount(accountHolderName);

            if (account == null)
            {
                Console.WriteLine($"No account found with name {accountHolderName}");
                return;
            }

            decimal amount;
            do
            {
                Console.Write("Enter amount to deposit : ");
                if (!decimal.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid Input, Please Enter Valid Input");
                }
            } while (amount == 0);
         
            DepositTransaction transaction = new DepositTransaction(account, amount);
            _bank.ExecuteTransaction(transaction);
        }

        // Method to transfer money between two accounts
        private static void DoTransfer()
        {
            Console.Write("Enter sender's account holder's name: ");
            string senderName = Console.ReadLine();
            Account senderAccount = _bank.GetAccount(senderName);

            if (senderAccount == null)
            {
                Console.WriteLine($"No account found with name {senderName}");
                return;
            }

            Console.Write("Enter recipient's account holder's name: ");
            string recipientName = Console.ReadLine();
            Account recipientAccount = _bank.GetAccount(recipientName);

            if (recipientAccount == null)
            {
                Console.WriteLine($"No account found with name {recipientName}");
                return;
            }

            decimal amount;
            do
            {
                Console.Write("Enter amount to transfer: ");
                if(!decimal.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid Input, Please Enter Valid Input");
                }
            }while (amount == 0);
           
            
            TransferTransaction transaction = new TransferTransaction(senderAccount, recipientAccount, amount);
            _bank.ExecuteTransaction(transaction);
        }

        // Method to print the details of an account
        private static void PrintAccount()
        {
            Console.Write("Enter account holder's name: ");
            string accountHolderName = Console.ReadLine();
            Account account = _bank.GetAccount(accountHolderName);

            if (account == null)
            {
                Console.WriteLine($"No account found with name {accountHolderName}");
                return;
            }

            account.Print();
        }
    }
}

using System;

namespace BankAccount4
{
    // Define a class named Program
    public class Program
    {
        private static Bank _bank = new Bank(); // Create an instance of the Bank class

        // Enum to represent different menu options
        private enum MenuOption
        {
            NewAccount = 1,
            Withdraw,
            Deposit,
            Transfer,
            Print,
            TransactionHistory,
            Quit
        }

        // Method to read user input and return the selected menu option
        private static MenuOption ReadUserOption()
        {
            int selection;
            do
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. New Account");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Print");
                Console.WriteLine("6. Transaction History");
                Console.WriteLine("7. Quit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }
            } while (selection < 1 || selection > 7);

            return (MenuOption)selection;
        }

        // Main method to start the program
        private static void Main()
        {
            MenuOption option;
            do
            {
                option = ReadUserOption(); // Read user's choice
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
                    case MenuOption.TransactionHistory:
                        PrintTransactionHistory();
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Exiting program.");
                        break;
                }
            } while (option != MenuOption.Quit); // Repeat until user chooses to quit
        }

        // Method to create a new account
        private static void CreateNewAccount()
        {
            Console.Write("Enter account holder's name: ");
            string accountHolderName = Console.ReadLine();

            decimal initialBalance;
            do
            {
                Console.Write("Enter initial Balance: ");
                if (!decimal.TryParse(Console.ReadLine(), out initialBalance))
                {
                    Console.WriteLine("Invalid Input, Please enter a valid number");
                }

            } while (initialBalance == 0);

            Account account = new Account(accountHolderName, initialBalance);

            _bank.AddAccount(account);
        }

        // Method to perform a withdrawal
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

        // Method to perform a deposit
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

        // Method to perform a transfer
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
                if (!decimal.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid Input, Please Enter Valid Input");
                }
            } while (amount == 0);

            TransferTransaction transaction = new TransferTransaction(senderAccount, recipientAccount, amount);
            _bank.ExecuteTransaction(transaction);
        }

        // Method to print account details
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

        // Method to print transaction history
        private static void PrintTransactionHistory()
        {
            _bank.PrintTransactionHistory();
        }
    }
}

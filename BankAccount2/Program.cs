using System;


namespace BankAccount2
{
    public class Program
    {
        private static MenuOption ReadUserOption()
        {
            int selection;
            do
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Transfer");
                Console.WriteLine("4. Print");
                Console.WriteLine("5. Quit");
                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }
            } while (selection < 1 || selection > 5);

            return (MenuOption)(selection - 1);
        }

        private static void DoWithdraw(Account account)
        {
            decimal amount;
            do
            {
                Console.Write("Enter amount to withdraw: ");
                if (!decimal.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number.");
                }

            } while (amount == 0);
            WithdrawTransaction withdrawTransaction = new WithdrawTransaction(account, amount);
            withdrawTransaction.Execute();
            withdrawTransaction.Print();
        }

        private static void DoDeposit(Account account)
        {
            decimal amount;
            do
            {
                Console.Write("Enter amount to deposit : ");
                if (!decimal.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid Input, Please Enter Valid Input");
                }
            } while (amount == 0);
            DepositTransaction depositTransaction = new DepositTransaction(account, amount);
            depositTransaction.Execute();
            depositTransaction.Print();
        }

        private static void DoTransfer(Account fromAccount, Account toAccount)
        {
            decimal amount;
            do
            {
                Console.Write("Enter amount to transfer: ");
                if (!decimal.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid Input, Please Enter Valid Input");
                }
            } while (amount == 0);
            TransferTransaction transferTransaction = new TransferTransaction(fromAccount, toAccount, amount);
            transferTransaction.Execute();
            transferTransaction.Print();
        }

        private static void Main()
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

            MenuOption option;
            do
            {
                option = ReadUserOption();
                switch (option)
                {
                    case MenuOption.Withdraw:
                        DoWithdraw(account);
                        break;
                    case MenuOption.Deposit:
                        DoDeposit(account);
                        break;
                    case MenuOption.Transfer:
                        Console.Write("Enter recipient's account holder's name: ");
                        string recipientName = Console.ReadLine();
                        Account recipientAccount = new Account(recipientName, 0);
                        DoTransfer(account, recipientAccount);
                        break;
                    case MenuOption.Print:
                        account.Print();
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Exiting program.");
                        break;
                }
            } while (option != MenuOption.Quit);
        }

        private enum MenuOption
        {
            Withdraw,
            Deposit,
            Transfer,
            Print,
            Quit
        }
    }

}

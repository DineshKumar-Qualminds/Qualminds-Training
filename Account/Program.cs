using System;

// Main program class
public class Program
{
    // Method to read and validate user input for menu options
    private static MenuOption ReadUserOption()
    {
        int selection;
        do
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Print");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");
            selection = Convert.ToInt32(Console.ReadLine());
        } while (selection < 1 || selection > 4);

        return (MenuOption)(selection - 1);
    }

    // Method to handle deposit operation
    private static void DoDeposit(Account account)
    {
        Console.Write("Enter amount to deposit: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());
        account.Deposit(amount);

    }

    // Method to handle withdrawal operation
    private static void DoWithdraw(Account account)
    {
        Console.Write("Enter amount to withdraw: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());
        account.Withdraw(amount);

    }
     
    // Main method
    private static void Main()
    {
        // Prompt the user to enter account holder's name
        Console.Write("Enter account holder's name: ");
        string accountHolderName = Console.ReadLine();

        // Prompt the user to enter initial balance
        Console.Write("Enter initial balance: ");
        decimal initialBalance = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine();    

        // Create an account with the entered name and balance
        Account account = new Account(accountHolderName, initialBalance);
        WithdrawTransaction withdrawTransaction = new WithdrawTransaction(account, 1000);
        DepositTransaction depositTransaction = new DepositTransaction(account,2000);

        // Execute the withdrawal transaction
        withdrawTransaction.Execute();

        // Print the details of the withdrawal transaction
        withdrawTransaction.Print();

        Console.WriteLine();    

        depositTransaction.Execute();

        depositTransaction.Print(); 


        MenuOption option;
        // Main program loop
        do
        {
            // Read user option
            option = ReadUserOption();
            // Perform actions based on user option
            switch (option)
            {
                case MenuOption.Withdraw:
                    DoWithdraw(account);
                    break;
                case MenuOption.Deposit:
                    DoDeposit(account);
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

    // Enumeration to represent menu options
    private enum MenuOption
    {
        Withdraw,
        Deposit,
        Print,
        Quit
    }
}

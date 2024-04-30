using System;

// Define a class to represent a withdrawal transaction
public class WithdrawTransaction
{
    private Account _account; // The account from which the withdrawal is made
    private decimal _amount; // The amount to be withdrawn
    private bool _executed = false; // Flag to track if the transaction has been executed
    private bool _success = false; // Flag to track if the withdrawal was successful
    private bool _reversed = false; // Flag to track if the transaction has been reversed

    // Property to get the success status of the transaction
    public bool Success
    {
        get { return _success; }
    }

    // Property to get the reversal status of the transaction
    public bool Reversed
    {
        get { return _reversed; }
    }

    // Constructor to initialize the transaction with an account and amount
    public WithdrawTransaction(Account account, decimal amount)
    {
        _account = account;
        _amount = amount;
    }

    // Method to execute the withdrawal transaction
    public void Execute()
    {
        if (_executed)
        {
            throw new Exception("Cannot execute this transaction as it has already been executed.");
        }

        _executed = true;
        _success = _account.Withdraw(_amount);

    }

    // Method to rollback (reverse) the withdrawal transaction
    public void Rollback()
    {
        if (!_executed)
        {
          
            throw new Exception("Cannot rollback this transaction as it has not been executed.");
        }

        if (_reversed)
        {
            
            throw new Exception("Cannot rollback this transaction as it has already been reversed.");
           
        }
       

        if (_success)
        {
            _reversed = true;
            _account.Deposit(_amount);
            Console.WriteLine("Withdrawal has been reversed.");
        }
    }

    // Method to print details of the withdrawal transaction
    public void Print()
    {
        Console.WriteLine("Withdraw Transaction Details:");
        Console.WriteLine($"Amount: {_amount}");
        Console.WriteLine($"Successful: {_success}");
        Console.WriteLine($"Reversed: {_reversed}");

    }
}

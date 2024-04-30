using System;
using System.Collections.Generic;
using System.Text;


using System;

// Define a class to represent a deposit transaction
public class DepositTransaction
{
    private Account _account; // The account to which the deposit is made
    private decimal _amount; // The amount to be deposited
    private bool _executed = false; // Flag to track if the transaction has been executed
    private bool _success = false; // Flag to track if the deposit was successful
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
    public DepositTransaction(Account account, decimal amount)
    {
        _account = account;
        _amount = amount;
    }

    // Method to execute the deposit transaction
    public void Execute()
    {
        if (_executed)
        {
            throw new Exception("Cannot execute this transaction as it has already been executed.");
        }

        _executed = true;
        _success = _account.Deposit(_amount);

    }

    // Method to rollback (reverse) the deposit transaction
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
            _account.Withdraw(_amount);
        }
    }

    // Method to print details of the deposit transaction
    public void Print()
    {
        Console.WriteLine("Deposit Transaction Details:");
        Console.WriteLine($"Amount: {_amount}");
        Console.WriteLine($"Successful: {_success}");
        Console.WriteLine($"Reversed: {_reversed}");
    }
}


using System;

public class Account
{
    private decimal _balance;
    private string _name;

    public Account(string name, decimal balance)
    {
        _name = name;
        _balance = balance;
    }

    public void Print()
    {
        Console.WriteLine($"Account Name: {_name}");
        Console.WriteLine($"Balance: {_balance}");
    }

    public string Name
    {
        get { return _name; }
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount to withdraw.");
            return false;
        }
        else if (amount > _balance)
        {
            Console.WriteLine("Insufficient funds.");
            return false;
        }

        _balance -= amount;
        Console.WriteLine($"Withdrawn: {amount}");
        Console.WriteLine($"Remaining Balance: {_balance}");

        return true;
    }

    public bool Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount to deposit.");
            return false;
        }

        _balance += amount;
        Console.WriteLine($"Deposited: {amount}");
        Console.WriteLine($"New Balance: {_balance}");
        return true;
    }
}

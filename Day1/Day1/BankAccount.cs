using System;

namespace Day1
{
    /// <summary>
    ///  This program calculates the available balance in a bank account
    /// after deducting HRA (House Rent Allowance), PF (Provident Fund) deductions,
    /// and any debited amount from the salary.
    /// </summary>
    class BankAccount
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args">A list of command line arguments</param>
        static void Main(string[] args)
        {
            // Declare variables to store user input and calculated values
            string accountHolderName;
            long accountNumber;
            double salary, hraDeduction, pfDeduction, debitedAmount, availableBalance;

            // Get account holder name from user input
            Console.Write("Enter Account Holder Name: ");
            accountHolderName = Console.ReadLine();


            // Get account number from user input
            Console.Write("Enter Account Number: ");
            accountNumber = Convert.ToInt64(Console.ReadLine());

            // Get salary amount from user input
            Console.Write("Enter Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());

            // Get HRA deduction amount from user input
            Console.Write("Enter HRA Deduction: ");
            hraDeduction = Convert.ToDouble(Console.ReadLine());

            // Get PF deduction amount from user input
            Console.Write("Enter PF Deduction: ");
            pfDeduction = Convert.ToDouble(Console.ReadLine());

            // Get debited amount from user input
            Console.Write("Enter Debited Amount: ");
            debitedAmount = Convert.ToDouble(Console.ReadLine());


            // Calculate available balance by subtracting deductions and debited amount from salary
            availableBalance = salary - hraDeduction - pfDeduction - debitedAmount;

            Console.WriteLine("\n\n");

            //Display the AccountHolderName
            Console.WriteLine("Account HolderName : " + accountHolderName);

            //Display the AccountNumber
            Console.WriteLine("Account Number : " + accountNumber);

            // Display the available balance to the user
            Console.WriteLine($"Available Balance: {availableBalance}");


        }
    }
}


/*
           DataType    Conversion
           ========    ==========
           byte         Convert.ToByte()
           sbyte        Convert.ToSByte() 
           short        Convert.ToInt16() 
           int          Convert.ToInt32() 
           uint         Convert.ToUInt32() 
           long         Convert.ToInt64()
           ulong        Convert.ToUInt64()
           float        Convert.ToSingle()
           double       Convert.ToDouble() 
           decimal      Convert.ToDecimal()
           bool         Convert.ToBoolean() 
           char         Convert.ToChar() 
           DateTime     Convert.ToDateTime()
*/
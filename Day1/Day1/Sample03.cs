/*
 * Sample.cs
 * This program creates a Sample class to declare,
 */



using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day1
{
   class Sample03
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber,result;

            Console.WriteLine("Enter FirstNumber : ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter SecondNuumber : ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            result = firstNumber + secondNumber;

            Console.WriteLine("Addition of " + firstNumber + " and " + secondNumber + " is " + result);
            Console.ReadKey();
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
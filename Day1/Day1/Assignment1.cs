/*
 * Sample.cs
 * This program creates a Assignment class to declare
 * initialize and display the variables.
 */

using System;
using System.Text;


namespace Day1
{
    /// <summary>
    /// Assignment class stores and displays the details
    /// using different data types
    /// </summary>
    class Assignment1
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args">A list of command line arguments</param>
        static void Main(string[] args)
        {
            //Declaring and initialising variables to store details

            //Integral Types 
                                                                                 //Range
            sbyte num1 = 127;   // signed  8-bit integer                        -128 to 127
            byte num2 = 255;    //unsigned  8-bit integer                        0 to 255 
            short num3 = 30000;   //Signed 16-bit integer                   -32,768 to 32,767
            ushort num4 = 60000;  //Unsigned 16 - bit integer                    0 to 65,535 
            int num5 = -9000;     //Signed 32-bit integer                 -2,147,483,648 to 2,147,483,647
            uint num6 = 4294967294;    //Unsigned 32-bit integer                0 to 4,294,967,295
            long num7 = 9190000000000000000; //Signed 64-bit integer	 -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong num8 = 1820;   //Unsigned 64-bit integer                0 to 18,446,744,073,709,551,615



            //Floating-Point Types 
                                           // Size     //Precision           //range     
            float floatValue = 16.66f;          // 4 bytes   ~6-9 digits           ±1.5 x 10−45 to ±3.4 x 1038
            double doubleValue = 24.12345678901236;     // 8 bytes   ~15-17 digits         ±5.0 × 10−324 to ±1.7 × 10308
            decimal decimalValue = 2.47m;         //16 bytes   	28-29 digits         ±1.0 x 10-28 to ±7.9228 x 1028



            //Other Numaric types 
            char letter= 'D';  //16 bit size 
            bool boolValue = true; //  Boolean value, which can be either true or false.

            // Reference Types
            object objVar = new object();
            string message = "Hello, C#!";

          


            // Arrays
            int[] intArray = { 1, 2, 3, 4, 5 };

            // Enumerations
            Days day = Days.Monday;

            // Structures
            Point point = new Point { x = 10, y = 20 };

     



            //Displaying the details 
            Console.WriteLine("sbyte value: " + num1);    
            Console.WriteLine("byte value: " + num2);    
            Console.WriteLine("short value: " + num3);
            Console.WriteLine("ushort value: " + num4);    
            Console.WriteLine("int value: {0}",num5);
            Console.WriteLine("sint value: {0}",num6);
            Console.WriteLine("long value: {0}",num7);
            Console.WriteLine("ulong value: {0}",num8);
            Console.WriteLine($"float value: {floatValue}");
            Console.WriteLine($"double value: {doubleValue}");
            Console.WriteLine($"decimal value: {decimalValue}");
            Console.WriteLine($"character: {letter}");
            Console.WriteLine($"bool value: {boolValue}");
            Console.WriteLine($"objVar: {objVar}");
            Console.WriteLine($"message: {message}");
            Console.WriteLine($"intArray: {string.Join(", ", intArray)}");
            Console.WriteLine($"day: {day}");
            Console.WriteLine($"point: ({point.x}, {point.y})");

            // Nullable Types
            int? nullableInt = null;

            if (nullableInt.HasValue)
            {
                Console.WriteLine("Value of nullableInt: " + nullableInt.Value);
            }
            else
            {
                Console.WriteLine("nullableInt is null");
            }

        }

        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        struct Point { public int x, y; };

    }
}


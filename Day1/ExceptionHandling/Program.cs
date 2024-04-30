using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {


            // IndexOutOfRangeException
            try
            {
                // Code that may throw an exception
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[4]); // This will throw an IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                // Handle the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Done with error handling.");
            }



            // OverflowException
            try
            {
                int maxValue = int.MaxValue;
                int sum = checked(maxValue + 1); // This will throw an OverflowException
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"OverflowException occurred: {ex.Message}");
            }

            // ArgumentException
            try
            {
                int[] numbers = { 1, 2, 3 };
                Array.Copy(numbers, 0, numbers, 1, 4); // This will throw an ArgumentException
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ArgumentException occurred: {ex.Message}");
            }

            // InvalidOperationException
            try
            {
                Queue<int> queue = new Queue<int>();
                int item = queue.Dequeue(); // This will throw an InvalidOperationException
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"InvalidOperationException occurred: {ex.Message}");
            }


            // DivideByZeroException
            // FormatException
            try
            {
                Console.Write("Enter 1st number:");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter 2st number:");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("The result is: " + z);


            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("Input must be numaric value.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End of the Program.");


        }
    }


}
    


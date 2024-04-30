using System;
using System.Collections.Generic;
using System.Text;


namespace ArrayTypes
{
    class ArrayMethods
    {
        
        static void Main()
        {
            // Create a list of integers
            List<int> numbers = new List<int> { 2, 6, 1, 4, 5, 3};

            // Add an element to the list
            numbers.Add(7);
            Console.WriteLine("List after adding 7:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");
            

            // Remove an element from the list
            numbers.Remove(3);
            Console.WriteLine("List after removing 3:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");


            // Find the index of an element in the list
            int index = numbers.IndexOf(4);
            Console.WriteLine($"Index of 4: {index}");
            Console.WriteLine("\n");


            // Remove an element at a specific index
            numbers.RemoveAt(1);
            Console.WriteLine("List after removing element at index 1:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");


            // Sort the list
            numbers.Sort();
            Console.WriteLine("Sorted list:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");


            // Reverse the list
            numbers.Reverse();
            Console.WriteLine("Reversed list:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");

            // Perform an action on each element 
            numbers.ForEach(x => Console.WriteLine($"Element: {x}"));
            Console.WriteLine("\n");


            // Find the first element greater than 5
            int greaterThanFive = numbers.Find(x => x > 5);
            Console.WriteLine($"First element greater than 5: {greaterThanFive}");
            Console.WriteLine("\n");

            //// Check if an element exists that is less than 0
            bool exists = numbers.Exists(x => x < 0);
            Console.WriteLine($"Exists element less than 0: {exists}");
            Console.WriteLine();




        }
    }
    


}

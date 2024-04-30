using System;
using System.Collections.Generic;

namespace ArrayTypes
{
    class JaggedArrays
    {
        static void Main(string[] args)
        {
            // Declare the array of two elements.
            int[][] arr = new int[2][];

            // Initialize the elements.
            arr[0] = [4, 6, 1, 8, 6,7];
            arr[1] = [3, 6, 2, 4];

            // Display the array elements.
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                   Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                 Console.WriteLine();
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTypes
{
    internal class ImplicitlyTypeArray
    {
        static void Main()
        {
            int[] array = new[] { 10, 20, 30, 40 }; // int[]

            Console.WriteLine("First element: " + array[0]);
            Console.WriteLine("Second element: " + array[1]);
            Console.WriteLine("Third element: " + array[2]);
            Console.WriteLine("Fourth element: " + array[3]);
            Console.WriteLine();
            

            var array2 = new[] { "Hello","World" }; // string[]

            Console.WriteLine(string.Join(" ", array2));
           
        }
    }
}

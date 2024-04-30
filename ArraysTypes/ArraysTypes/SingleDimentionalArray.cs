using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTypes
{
    class SingleDimentionalArray
    {
        static void Main(string[] args)
        {

            //Single-Dimentional array of 5 integers

            int[] array1 = new int[5];
            array1[0] = 10;
            array1[1] = 20;
            array1[2] = 30;
            array1[3] = 40;
            array1[4] = 50;

            Console.WriteLine(array1[0]);     //10 
            Console.WriteLine(array1[1]);     //20 
            Console.WriteLine(array1[2]);     //30 
            Console.WriteLine(array1[3]);     //40 
            Console.WriteLine(array1[4]);     //50 



            Console.WriteLine("\n");

            //Declare set of array element values
            int[] array2 = [1, 2, 3, 4, 5];

            foreach (int i in array2)
            {

                Console.WriteLine(i);
            }

            Console.WriteLine("\n");


            string[] weekdays = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];

            foreach (string day in weekdays)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("\n");
        }
    }
}

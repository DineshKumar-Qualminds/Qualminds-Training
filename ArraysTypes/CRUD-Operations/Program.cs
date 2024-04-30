using System;

namespace CRUD_Operations
{
    class Program
    {
        static void Main()
        {
            // Create an array of strings
            string[] names = new string[5];

            // Create operation
            names[0] = "Harsha";
            names[1] = "Vamsi";
            names[2] = "Sekhar";
            names[3] = "Prathap";
            names[4] = "Pavan";

            // Read operation
            Console.WriteLine("Read Operation:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Update operation
            names[2] = "Kumar";

            // Delete operation
            names[4] = null;

            Console.WriteLine("\nAfter Update and Delete Operations:");
            foreach (string name in names)
            {
                if (name != null)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }

}

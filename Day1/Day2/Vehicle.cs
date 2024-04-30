using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Vehicle
    {

        static void Main()
        {
            // Create a new instance of Car
            Car car1 = new Car();


            // Set specifications for car1
            car1.Specifications("AUDI", "Audi Q3", 2024, "RED", 43.81m, "Petrol", 14.93f, 192, 1984, "Automatic", 222f, 4);

            // Display specifications of car1
            Console.WriteLine(car1.SpecificationDetails());


            Car car2 = new Car();
            // Set specifications for car2
            car2.Specifications("BMW", "BMW X1", 2024, "BLUE", 49.50m, "Diesel", 20.37f, 148, 1995, "Automatic", 147f, 4);


            // Display specifications of car2
            Console.WriteLine(car2.SpecificationDetails());
        }
    }
}

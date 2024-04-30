using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInterfaceProject
{
    internal class Boat : IVehicle
    {
        private string make;
        private int numberOfWheels;
        private string vehicleType;

        public void Make(string company)
        {
            make = company;
            Console.WriteLine($"Make: {make}");
        }

        public void NumberOfWheels(int number)
        {
            numberOfWheels = number;
            Console.WriteLine($"Number of Wheels: {numberOfWheels}");
        }

        public void VehicleType(string transportMode)
        {
            vehicleType = transportMode;
            Console.WriteLine($"Vehicle Type: {vehicleType}");
        }
    }

}

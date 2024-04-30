using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travels
{
    // Water vehicle class inherits from Vehicle
    public class Boat : Vehicle
    {
        // Child specific field
        protected double weight;

        // Constructor
        public Boat(int serialNo, string make, string model, string color,double weight): base(serialNo, make, model, color)
        {
            this.weight = weight;   
        }
        public void GetInfo()
        {
            Console.WriteLine($"Car Details: Serial Number: {serialNo}, Make: {_make}, Model: {_model}, Color: {color}, Weight: {weight}");
        }

        // Implementation of abstract methods from Vehicle
        public override void Start()
        {
            Console.WriteLine("Boat engine starting...");
        }

        public override double GetTopSpeed()
        {
            return 40; // Example top speed for a boat (replace with logic)
        }

        public void DropAnchor()
        {
            Console.WriteLine("Dropping anchor...");
        }

        // Override virtual method from Vehicle to handle refueling for boats
        public override void Refuel(double amount)
        {
            Console.WriteLine($"Refueling boat with {amount} liters of fuel");
        }
        // Sealed method specific to Boat (cannot be overridden)
        public sealed override void Maintenance()
        {
            Console.WriteLine("Performing Boat Maintenance...");
        }

    }
}

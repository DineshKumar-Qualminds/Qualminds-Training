using System;
using static Travels.Car;


namespace Travels
{
    public class Car : Vehicle
    {
        public int numberOfWheels;//specific Car filed 

        // Constructor
        public Car(int serialNo, string _make, string _model, string color,int numberOfWheels) : base(serialNo, _make, _model, color)
        {
            this.numberOfWheels = numberOfWheels;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Car Details: Serial Number: {serialNo}, Make: {_make}, Model: {_model}, Color: {color}, Number of Wheels: {numberOfWheels}");
        }

        //Implementation Abstract methods
        public override void Start()
        {
            Console.WriteLine("Car Engine Starts");
        }

        public override double GetTopSpeed()
        {
            return 150;
        }

        public void OpenSunroof()
        {
            Console.WriteLine("Opening sunroof...");
        }


        //override virtual method implementation from vehicle 
        public override void Stop()
        {
            Console.WriteLine("Car applying brakes");
            base.Stop();
        }

        public sealed override void Maintenance()
        {
            Console.WriteLine("Performing Car Maintenance...");
        }
    

    }
   
}


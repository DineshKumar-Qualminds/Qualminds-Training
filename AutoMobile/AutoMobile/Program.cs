
//Base class for Travllinhg mode
using System;

    public abstract class Vehicle
    {
        //Abstract method to used vehicle
        public abstract void VehicleType(int numSeats);
    }


    //Derived class for Car Type
    public class Car : Vehicle
    {
        public override void VehicleType(int numSeats)
        {
            Console.WriteLine($"number of seats available {numSeats}");
        }
    }

    //Derived class for BusType
    public class Bus : Vehicle
    {
        public override void VehicleType(int numSeats)
        {
            Console.WriteLine($"number of seats available {numSeats}");
        }

    }

    public class Travels
    {
        public void Booked(Vehicle vehicle, int numSeats)
        {
            vehicle.VehicleType(numSeats);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Travels travels = new Travels();

            Vehicle car = new Car();
            Vehicle bus = new Bus();

            travels.Booked(car, 200);
            travels.Booked(bus, 600);

        }

    }



    

  
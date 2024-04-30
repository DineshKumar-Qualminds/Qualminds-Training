namespace VehicleInterfaceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make("BMW");
            car.NumberOfWheels(4);
            car.VehicleType("private");
            Console.WriteLine();

            Bike bike = new Bike();
            bike.Make("Honda");
            bike.NumberOfWheels(2);
            bike.VehicleType("personal");
            Console.WriteLine();

            Boat boat = new Boat();
            boat.Make("Yamaha");
            boat.NumberOfWheels(0); 
            boat.VehicleType("sailing");
            Console.WriteLine();

            Flight flight = new Flight();
            flight.Make("Boeing");
            flight.NumberOfWheels(16); 
            flight.VehicleType("commercial");
            Console.WriteLine();
        }
    }
}

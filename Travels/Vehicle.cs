using static Travels.Car;

namespace Travels
{
    public abstract class Vehicle
    {
        //fields
        protected int serialNo;
        protected string _make;
        protected string _model;
 
        public virtual string color { get; set; } //property

        //Constructor
        public Vehicle(int serialNo, string _make, string _model, string color)
        {
            this.serialNo = serialNo;
            this._make = _make;
            this._model = _model;
            this.color = color;
        }


        //Abstract Methods 
        public abstract void Start();
        public abstract double GetTopSpeed();

        //Virtual Methods
        public virtual void Stop()
        {
            Console.WriteLine("Vehicle is Stopping");
        }
        public virtual void Refuel(double amount)
        {
            Console.WriteLine($"Refueling vehicle with {amount} units");
        }


        // Sealed method
        public virtual void Maintenance()
        {
            Console.WriteLine("Performing maintenance...");
        }


        public static void Main()
        {
            Car car = new Car(555,"BMW","BMW X7","Blue",4);
            car.Start();
            car.GetInfo();
            car.OpenSunroof();
            car.Stop();
            car.Maintenance();
            Console.WriteLine("Top Speed : " + car.GetTopSpeed());
            Console.WriteLine();


            Boat boat = new Boat(7890, "Yamaha", "WaveRunner", "Orange",1000);
            boat.Start();
            boat.GetInfo();
            boat.DropAnchor();
            boat.Refuel(100);
            boat.Maintenance();

            Console.WriteLine();    

            ElectricCar electricCar = new ElectricCar(35345, "Tesla", "Model 3", "White", 4, 6.15);
            electricCar.Start();
            electricCar.Stop();
            electricCar.ChargeBattery();

        }
    }
    
}

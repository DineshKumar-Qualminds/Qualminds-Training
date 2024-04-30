using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travels
{
    public sealed class ElectricCar : Car
    {
        private double chargingTime;
        public ElectricCar(int serialNo, string _make, string _model, string color, int numberOfWheels, double chargingTime) : base(serialNo, _make, _model, color, numberOfWheels)
        {
            this.chargingTime = chargingTime;
        }
        public override void Start()
        {
            Console.WriteLine("Electric car engine starting...");
        }

        public override double GetTopSpeed()
        {
            return 200;
        }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging the battery...");
        }

    }

}

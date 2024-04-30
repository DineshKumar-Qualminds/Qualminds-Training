using System;
using System.Text;

//Main  Program File is Vehicle.cs
namespace Day2
{
    // Car class represents a car with various properties
    public class Car    {
        // Private fields to store car details
        private string _make;
        private string _model;
        private int year;
        private string color;
        private decimal price;
        private string fuelType;
        private float mileage;
        private float horsePower;
        private int engineCC;
        private string transmissionType;
        private float speed;
        private int seatingCapacity;

        //Car Make Property
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        //Car Model Propery 
        public string Model
        {
            get {return  _model; }  
            set { _model = value; }
        }


        // Color Property
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        
        //Car Manufacturing Year Property 
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        // Price Property
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        // Fuel Type Property
        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }

        // Mileage Property
        public float Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        // Horse Power Property
        public float HorsePower
        {
            get {return horsePower;}
            set{ horsePower = value;}
        }

        // Engine CC Property
        public int EngineCC
        {
            get { return engineCC;}
            set { engineCC = value; }
        }

        // Transmission Type Property
        public string TransmissionType 
        { 
           get { return transmissionType; }
           set { transmissionType = value; } 
        }

        // Speed Property
        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        // Seating Capacity Property
        public int SeatingCapacity
        {
            get { return seatingCapacity; }
            set { seatingCapacity = value; }
        }


        //Method to set car specifications
        public void Specifications(string _make, string _model, int year, string color, decimal price, string fuelType, float mileage, float horsePower, int engineCC, string transmissionType, float speed, int seatingCapacity)
        {
            Make = _make;
            Model = _model;
            Year = year;
            Color = color;
            Price = price;
            FuelType = fuelType;
            Mileage = mileage;
            HorsePower = horsePower;
            EngineCC = engineCC;
            TransmissionType = transmissionType;
            Speed = speed;
            SeatingCapacity = seatingCapacity;

        }

        // Method to display car specifications
        public string SpecificationDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Make = {0}{1}", _make, Environment.NewLine);
            sb.AppendFormat("Model = {0}{1}",_model, Environment.NewLine);
            sb.AppendFormat("Year = {0}{1}", year, Environment.NewLine);
            sb.AppendFormat("Color = {0}{1}", color, Environment.NewLine);
            sb.AppendFormat("Price = {0}{1}{2}",price, "Lakh",Environment.NewLine);
            sb.AppendFormat("FuelType = {0}{1}", fuelType, Environment.NewLine);
            sb.AppendFormat("Mileage ={0}{1}{2}",mileage,"kmpl", Environment.NewLine);
            sb.AppendFormat("HorsePower = {0}{1}{2}", horsePower,"bhp", Environment.NewLine);
            sb.AppendFormat("EngineCC = {0}{1}{2}", engineCC,"cc",Environment.NewLine);
            sb.AppendFormat("TrasmissionType = {0}{1}", transmissionType, Environment.NewLine);
            sb.AppendFormat($"Speed = {Speed} kmph {Environment.NewLine}");
            sb.AppendFormat($"Seating Capacity = {SeatingCapacity}{Environment.NewLine}");
            return sb.ToString();
        }

    }

}

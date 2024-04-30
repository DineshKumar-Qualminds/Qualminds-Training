using System;
using System.Collections.Generic;

namespace FlightProject
{
    // Abstract base class for flights
    public abstract class Flight
    {
        // Fields with properties
        public string FlightNumber { get; set; }
        public string FlightCompany { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int AvailableSeats { get; set; }
        public int Price { get; set; }

        //Constructor
        public Flight(string flightNumber, string flightCompany, string departureCity, string arrivalCity, DateTime departureTime, DateTime arrivalTime, int availableSeats, int price)
        {
            FlightNumber = flightNumber;
            FlightCompany = flightCompany;
            DepartureCity = departureCity;
            ArrivalCity = arrivalCity;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            AvailableSeats = availableSeats;
            Price = price;
        }

        // Abstract method for booking
        public abstract void BookTicket();

        // Virtual method for canceling
        public virtual void CancelTicket()
        {
            Console.WriteLine("Booking cancelled.");
        }

        // Normal method for checking availability
        public void CheckAvailability()
        {
            Console.WriteLine($"Available seats: {AvailableSeats}");
        }

        
        public virtual void DisplayFlightDetails()
        {
            Console.WriteLine($"Flight: {FlightNumber}");
            Console.WriteLine($"From: {DepartureCity} To: {ArrivalCity}");
            Console.WriteLine($"Departure: {DepartureTime} Arrival: {ArrivalTime}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Available Seats: {AvailableSeats}");
        }

        // Sealed method
        public virtual void Maintenance()
        {
            Console.WriteLine("Scheduled aircraft maintenance");
        }

    }

    class Program
    {
        static void Main()
        {
            //Creating DomesticFlight Instance and call methods
            DomesticFlight domesticFlight = new DomesticFlight("6E 0318", "IndiGo", "Kolkata", "Mubai", DateTime.Now, DateTime.Now.AddHours(4), 150, 6000, 25);
            domesticFlight.BookTicket();
            domesticFlight.DisplayFlightDetails();
            domesticFlight.Maintenance();


            Console.WriteLine();

            //Creating InternationalFlight Instance and call methods
            InternationalFlight internationalFlight = new InternationalFlight("OZ6807", "Asiana Airlines", "NewDelhi", "Las Vegas", DateTime.Now, DateTime.Now.AddHours(48), 100, 85000,80, "B-2");
            internationalFlight.CancelTicket();
            internationalFlight.DisplayFlightDetails();

            Console.WriteLine() ;

            //Creating BusinessClassFlight Instance and call methods
            BusinessClassFlight businessClassFlight = new BusinessClassFlight("BF001", "FlightCompany", "Tokyo", "Sydney", DateTime.Now, DateTime.Now.AddHours(6), 50, 150000, new string[] { "Lounge access", "Priority boarding","Extra legroom","Premium meals and beverages","In-flight entertainment","Comfort kits","Dedicated flight attendants" });
            businessClassFlight.BookTicket();
            businessClassFlight.DisplayFlightDetails();
            businessClassFlight.CheckAvailability();
        }
    }
}

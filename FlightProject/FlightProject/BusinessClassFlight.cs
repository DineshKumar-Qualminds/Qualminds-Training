using System;
using System.Collections.Generic;
using System.Text;


namespace FlightProject
{
    //Derived class for business class flights
    public class BusinessClassFlight : Flight
    {
        // Additional field for amenities
        public string[] Amenities { get; set; }

        //Constructor
        public BusinessClassFlight(string flightNumber, string flightCompany, string departureCity, string arrivalCity, DateTime departureTime, DateTime arrivalTime, int availableSeats, int price,string[] amenities)
            : base(flightNumber, flightCompany, departureCity, arrivalCity, departureTime, arrivalTime, availableSeats, price)
        {
            Amenities = amenities;
        }

        // Implementation of abstract method for booking
        public override void BookTicket()
        {
            Console.WriteLine($"Booking business class flight {FlightNumber}...");
        }

        // Override method for displaying flight details
        public override void DisplayFlightDetails()
        {
            Console.WriteLine("Business Class Flight Details:");
            base.DisplayFlightDetails();
            Console.WriteLine("Amenities:");
            foreach (var amenity in Amenities)
            {
                Console.WriteLine($"- {amenity}");
            }
        }
    }
}

using System;
using System.Text;


namespace FlightProject
{
    // Derived class DomesticFlight
    public class DomesticFlight : Flight
    {
        // Fields with properties
        public int BaggageAllowance { get; set; }

        // Constructor
        public DomesticFlight(string flightNumber, string flightCompany, string departureCity, string arrivalCity, DateTime departureTime, DateTime arrivalTime, int availableSeats, int price, int baggageAllowance)
            : base(flightNumber, flightCompany, departureCity, arrivalCity, departureTime, arrivalTime, availableSeats, price)
        {
            BaggageAllowance = baggageAllowance;
        }

        // Abstract override method
        public override void BookTicket()
        {
            Console.WriteLine($"Booking domestic flight {FlightNumber}...");
        }

        // Override method to display flight details
        public override void DisplayFlightDetails()
        {
            Console.WriteLine("Domestic Flight Details:");
            base.DisplayFlightDetails();
            Console.WriteLine($"Baggage Allowance: {BaggageAllowance} kg");
        }

        // Sealed override method for maintenance
        public sealed override void Maintenance()
        {
            Console.WriteLine("Scheduled DomesticFlight Maintenance");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject
{
    //Derived class International class flights
    public class InternationalFlight : Flight
    {
        // Additional fields for baggage allowance and visa requirement
        public int BaggageAllowance { get; set; }
        public string VisaRequirement { get; set; }

        //Constructor
        public InternationalFlight(string flightNumber, string flightCompany, string departureCity, string arrivalCity, DateTime departureTime, DateTime arrivalTime, int availableSeats, int price, int baggageAllowance, string visaRequirement)
            : base(flightNumber, flightCompany, departureCity, arrivalCity, departureTime, arrivalTime, availableSeats, price)
        {

            VisaRequirement = visaRequirement;
            BaggageAllowance = baggageAllowance;
        }

        // Implementation of abstract method for booking
        public override void BookTicket()
        {
            Console.WriteLine($"Booking international flight {FlightNumber}...");
        }


        // Override method for displaying flight details
        public override void DisplayFlightDetails()
        {
            Console.WriteLine("International Flight Details:");
            base.DisplayFlightDetails();
            Console.WriteLine($"Visa Requirement: {VisaRequirement}");
            Console.WriteLine($"Baggage Allowance: {BaggageAllowance} kg");
        }
    }
}

using Day3;
using System;

// Enum for different types of flights
public enum FlightType
{
    Domestic,
    International,
    BusinessClass
}

// Base class for all flights
public abstract partial class Flight
{
    public string FlightNumber { get; set; }
    public string DepartureCity { get; set; }
    public string ArrivalCity { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public int AvailableSeats { get; set; }
    public int Price { get; set; }  

    public abstract void BookTicket();
    public abstract void CancelTicket();
    public abstract void CheckAvailability();

    
}

class Program
{
    static void Main()
    {
        // Sample usage
        DomesticFlight domesticFlight = new DomesticFlight();
        domesticFlight.BookTicket();
        domesticFlight.CancelTicket();
        domesticFlight.CheckAvailability();

        InternationalFlight internationalFlight = new InternationalFlight();
        internationalFlight.BookTicket();
        internationalFlight.CancelTicket();
        internationalFlight.CheckAvailability();

        BusinessClassFlight businessClassFlight = new BusinessClassFlight();    
        businessClassFlight.BookTicket();
        businessClassFlight.CancelTicket();
        businessClassFlight.CheckAvailability();
    }
}
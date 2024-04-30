using System;

public partial class InternationalFlight : Flight
{
    public int BaggageAllowance { get; set; }

    public override void BookTicket()
    {
        // Implementation for booking an international flight ticket
        Console.WriteLine("Booking a ticket for an international flight.");
    }

    public override void CancelTicket()
    {
        // Implementation for canceling an international flight ticket
        Console.WriteLine("Canceling a ticket for an international flight.");
    }

    public override void CheckAvailability()
    {
        // Implementation for checking availability of international flights
        Console.WriteLine("Checking availability of international flights.");
    }
}

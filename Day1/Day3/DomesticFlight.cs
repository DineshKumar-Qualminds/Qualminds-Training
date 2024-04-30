using System;

public partial class DomesticFlight : Flight
{
    public int BaggageAllowance { get; set; }

    public override void BookTicket()
    {
        // Implementation for booking a domestic flight ticket
        Console.WriteLine("Booking a ticket for a domestic flight.");
    }

    public override void CancelTicket()
    {
        // Implementation for canceling a domestic flight ticket
        Console.WriteLine("Canceling a ticket for a domestic flight.");
    }

    public override void CheckAvailability()
    {
        // Implementation for checking availability of domestic flights
        Console.WriteLine("Checking availability of domestic flights.");
    }
}

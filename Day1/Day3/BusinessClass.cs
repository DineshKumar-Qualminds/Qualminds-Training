using System;

public partial class BusinessClassFlight : Flight
{
    public string AdditionalAmenity { get; set; }

    public override void BookTicket()
    {
        // Implementation for booking a business class flight ticket
        Console.WriteLine("Booking a ticket for a business class flight.");
    }

    public override void CancelTicket()
    {
        // Implementation for canceling a business class flight ticket
        Console.WriteLine("Canceling a ticket for a business class flight.");
    }

    public override void CheckAvailability()
    {
        // Implementation for checking availability of business class flights
        Console.WriteLine("Checking availability of business class flights.");
    }

    public void SetAdditionalAmenity(string amenity)
    {
        AdditionalAmenity = amenity;
    }

    public string GetAdditionalAmenity()
    {
        return AdditionalAmenity;
    }
}



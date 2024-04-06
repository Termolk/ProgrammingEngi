namespace ProgrammingEngi.secondLabTaxi;

public class Ride : Order
{
    public decimal CostPerHouse { get; set; }
    public int Hours { get; set; }
    
    public override decimal CostForRide => Hours * CostPerHouse;
}
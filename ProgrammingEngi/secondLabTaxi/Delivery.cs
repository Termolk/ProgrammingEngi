namespace ProgrammingEngi.secondLabTaxi;

public class Delivery : Order
{
    public decimal CostPerLoadingUnloading { get; set; }
    public decimal CostOfDelivery { get; set; }

    public override decimal CostForRide => CostPerLoadingUnloading + CostOfDelivery;
}
namespace ProgrammingEngi.secondLabTaxi;

public class ListOrder : List<Order>
{
    public decimal GetAllPriceForAllRides() => this.Sum(x=>x.CostForRide);

    // public decimal GetAllPriceForAllRides2()
    // {
    //     decimal summ = 0;
    //     foreach (var ride in this)
    //     {
    //         summ += ride.CostForRide;
    //     }
    //
    //     return summ;
    // }

    // public decimal GetAllPriceForAllRides1()
    // {
    //     decimal summ = 0;
    //     for (int i = 0; i < this.Count(); i++)
    //     {
    //         summ += this[i].CostForRide;
    //     }
    //
    //     return summ;
    // }
}
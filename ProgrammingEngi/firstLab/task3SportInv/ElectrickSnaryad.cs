using System.Collections.ObjectModel;

namespace ProgrammingEngi.firstLab.task3SportInv;

public abstract class ElectrickSnaryad : BigSportItem
{
    public Collection<object> ListOfModes { get; set; }
    public float Tension { get; set; }
}
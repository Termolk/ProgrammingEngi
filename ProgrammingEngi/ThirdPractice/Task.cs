namespace ProgrammingEngi.ThirdPractice;

/*
 * класс 1: двигатель внутреннего сгорания
 * Объем
 * Мощность (л/с)
 * Показать характеристики
 *
 * класс 2:
 * плотность
 * октнановое число
 *
 * класс 3 дизель
 * плотность
 * время прогрева
 */

public class Task
{
    
}



public class Engine<T> where T : FuelBase
{
    protected T fuel;

    /// <summary>
    /// Конструктор класса двигатель
    /// </summary>
    /// <param name="fuel">Вид топлива</param>
    /// <exception cref="ArgumentNullException"></exception>
    public Engine(T fuel)
    {
        this.fuel = fuel ??
                    throw new ArgumentNullException(nameof(fuel));
    }

    public decimal Volume { get; set; }
    public int Power { get; set; }
    public string ShowFuelCharacteristics() => this.fuel.GetChars();
}

public abstract class FuelBase
{
    public decimal Density { get; set; }
    public abstract string GetChars();
}

public class Petrol : FuelBase
{
    public int OctanNumber { get; set; }
    public override string GetChars() => $"Бензин с октановым числом {this.OctanNumber}";
}

public class Diesel : FuelBase
{
    public int PrepareTime { get; set; }
    public override string GetChars() => $"Дизель с временем прогрева {this.PrepareTime}";
}


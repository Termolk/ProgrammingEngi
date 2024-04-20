using ProgrammingEngi.ThirdPractice;

var enginePetrol = new Engine<Petrol>(new Petrol());
var engineDiesel = new Engine<Diesel>(new Diesel());

Console.WriteLine(enginePetrol.ShowFuelCharacteristics());
Console.WriteLine(engineDiesel.ShowFuelCharacteristics());
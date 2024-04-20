// Семинар третий
// using ProgrammingEngi.ThirdPractice;
//
// var enginePetrol = new Engine<Petrol>(new Petrol());
// var engineDiesel = new Engine<Diesel>(new Diesel());
//
// Console.WriteLine(enginePetrol.ShowFuelCharacteristics());
// Console.WriteLine(engineDiesel.ShowFuelCharacteristics());

using ProgrammingEngi.ThirdPractice;

var phoneList = new List<BaseContact>()
{
    new PhoneContact() { Name = "Ser", Phone = "88005553535" },
    new PhoneContact() { Name = "Vlad", Phone = "88005553535" },
};

var emailList = new List<BaseContact>()
{
    new EmailContact() { Name = "Ser", Email = "fdsfsdf@gmail.com" },
    new EmailContact() { Name = "Vlad", Email = "fdsfdsfsdfsdfsdf@yaho.com" },
};

var contackBook = new ContactBook(phoneList, emailList);
foreach (var contact in contackBook.GetAllContacts)
{
    Console.WriteLine($"Данные контакта: {contact.GetCharacteristics()}");
}

Console.WriteLine();
Console.WriteLine($"Кол-во записей: {contackBook.GetCountOfContacts()}");
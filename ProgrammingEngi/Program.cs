using ProgrammingEngi.FirstPractice;
using ProgrammingEngi.secondLabTaxi;

var rides = new ListOrder()
{
    new Ride(){VIM = "1e12CDs", Hours = 2, CostPerHouse = 10},
    new Ride(){VIM = "1e12CDs", Hours = 2, CostPerHouse = 10},
    new Delivery(){VIM = "1e12CDs", CostPerLoadingUnloading = 1, CostOfDelivery = 30},
};

Console.WriteLine($"Полнгая стоимость: {rides.GetAllPriceForAllRides()}");






















// PRACTICE FIRST
// var students = new StudentList()
// {
//   new Student(){Name = "test1", Year = 1},  
//   new Student(){Name = "test1", Year = 1},  
//   new Student(){Name = "test1", Year = 1},  
//   new Student(){Name = "test1", Year = 1},  
//   new Student(){Name = "test1", Year = 1}  
// };
//
// var yeasr = students.GetYearsCount();
// foreach (var year in yeasr)
// {
//   Console.WriteLine($"{year.Key} курс - {year.Value} студентов");
// }
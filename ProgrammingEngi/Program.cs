using ProgrammingEngi.FirstPractice;

var students = new StudentList()
{
  new Student(){Name = "test1", Year = 1},  
  new Student(){Name = "test1", Year = 1},  
  new Student(){Name = "test1", Year = 1},  
  new Student(){Name = "test1", Year = 1},  
  new Student(){Name = "test1", Year = 1}  
};

var yeasr = students.GetYearsCount();
foreach (var year in yeasr)
{
  Console.WriteLine($"{year.Key} курс - {year.Value} студентов");
}
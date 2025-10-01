using System;
using System.Text;
using FundamentalsHRM.Accounting;
using FundamentalsHRM.HR;



Console.WriteLine("Creating an Employee");
Console.WriteLine("--------------------\n");

Employee ahmed = new Employee("Ahmed", "Mohamed", "Ahmed@Mohamd.com",DateTime.Parse("12/2/2000"),350, EmployeeType.Manager);


ahmed.PerformWork(25);

ahmed.ReciveWage();

Employee max = new("Max", "Tourest", "Jack@Luck.com", new DateTime(1999, 8, 25), 250, EmployeeType.Research);

 max.PerformWork(40);

max.ReciveWage();

WorkTask task;
task.description = "New Task";
task.hours = 3;
task.PerformWorkTask();

ahmed.PerformWork(30);
max.PerformWork(35);
ahmed.DisplayEmployeeDetails();
max.DisplayEmployeeDetails();

FundamentalsHRM.Accounting.Customer customer = new FundamentalsHRM.Accounting.Customer();
#region GC Test

List<Employee> employees = new List<Employee>();
for  (int i = 0; i < 10000000; i++)
{
    Employee randomEmployee = new Employee(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),new DateTime(1980,2,19), null, EmployeeType.StoreManager);
    employees.Add(randomEmployee);
}
employees.Clear();
employees = null;

GC.Collect();

Console.ReadLine();
#endregion
#region Record Test
Account account = new Account("2020202020");
//account.AccountNumber = "7000"; // Error since immutability 

#endregion
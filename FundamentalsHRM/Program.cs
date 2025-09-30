using System;
using FundamentalsHRM;

Console.WriteLine("Creating an Employee");
Console.WriteLine("--------------------\n");

Employee ahmed = new Employee("Ahmed", "Mohamed", "Ahmed@Mohamd.com",DateTime.Parse("12/2/2000"),500);
ahmed.DisplayEmployeeDetails();

ahmed.PerformWork();
ahmed.PerformWork();
ahmed.PerformWork(20);
ahmed.PerformWork(2);
ahmed.PerformWork(6);

ahmed.ReciveWage();

Console.WriteLine("\n\nCreating an Employee");
Console.WriteLine("--------------------\n");

Employee jack = new("Jack", "Luck", "Jack@Luck.com", new DateTime(1999,8,25), 250);
jack.DisplayEmployeeDetails();

jack.PerformWork(20);
jack.PerformWork();
jack.PerformWork();

var jackWage = jack.ReciveWage(true);
Console.WriteLine($"Jack wage paid (Message from program): {jackWage}");
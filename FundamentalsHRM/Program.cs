using System;
using FundamentalsHRM;



// int a = 42;
// int aCopy = a;
// Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");
// aCopy = 100;
// Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");


Console.WriteLine("Creating an Employee");
Console.WriteLine("--------------------\n");

Employee ahmed = new Employee("Ahmed", "Mohamed", "Ahmed@Mohamd.com",DateTime.Parse("12/2/2000"),500);
Employee testEmployee = ahmed;
ahmed.DisplayEmployeeDetails();
testEmployee.DisplayEmployeeDetails();
testEmployee.firstName = "Test";

ahmed.DisplayEmployeeDetails();
testEmployee.DisplayEmployeeDetails();

// ahmed.DisplayEmployeeDetails();

// ahmed.PerformWork();
// ahmed.PerformWork();
// ahmed.PerformWork(20);
// ahmed.PerformWork(2);
// ahmed.PerformWork(6);

// ahmed.ReciveWage();

// Console.WriteLine("\n\nCreating an Employee");
// Console.WriteLine("--------------------\n");

// Employee jack = new("Jack", "Luck", "Jack@Luck.com", new DateTime(1999,8,25), 250);
// jack.DisplayEmployeeDetails();

// jack.PerformWork(20);
// jack.PerformWork();
// jack.PerformWork();

// var jackWage = jack.ReciveWage(true);
// Console.WriteLine($"Jack wage paid (Message from program): {jackWage}");

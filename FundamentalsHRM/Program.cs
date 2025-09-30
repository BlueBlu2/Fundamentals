using System;
using System.Text;
using FundamentalsHRM;



// int a = 42;
// int aCopy = a;
// Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");
// aCopy = 100;
// Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");


Console.WriteLine("Creating an Employee");
Console.WriteLine("--------------------\n");

Employee ahmed = new Employee("Ahmed", "Mohamed", "Ahmed@Mohamd.com",DateTime.Parse("12/2/2000"),350, EmployeeType.Manager);

// string name = "Aly";
// string anotherName = name;
// name += " Hassan";

// Console.WriteLine("Name: " + name);
// Console.WriteLine("Another Name: " + anotherName);

// string upperCaseName = name.ToUpper();
// Console.WriteLine("Name: " + name);
// Console.WriteLine("Uppercase Name: " + upperCaseName);

// string firstName = "Zaki";
// string lastName = "Chan";

// StringBuilder sp = new StringBuilder();

// sp.Append("Last name: ");
// sp.AppendLine(lastName);
// sp.Append("First name: ");
// sp.Append(firstName);
// Console.WriteLine(sp.ToString());


// StringBuilder sp2 = new StringBuilder();
// for (int i = 0; i < 2500; i++)
// {
//     sp2.Append(i);
//     sp2.Append(" ");
// }

// string list = sp2.ToString();
// Console.WriteLine(list);

ahmed.PerformWork(25);
// int minimumBonus = 100;
// int recivedBonus = ahmed.CalculateBonus(minimumBonus);
//Console.WriteLine($"The minimum bonus is: {minimumBonus} and {ahmed.firstName} has recived a bonus of {recivedBonus}");
ahmed.ReciveWage();

Employee max = new("Max", "Tourest", "Jack@Luck.com", new DateTime(1999, 8, 25), 250, EmployeeType.Research);
// int bonusTax;
 max.PerformWork(40);
// int recivedBonus = max.CalculateBonusAndBonusTax(minimumBonus,out bonusTax);
// Console.WriteLine($"The minimum bonus is: {minimumBonus}, the bonus tax is {bonusTax}, and {ahmed.firstName} has recived a bonus of {recivedBonus}");
max.ReciveWage();
// Employee testEmployee = ahmed;
// ahmed.DisplayEmployeeDetails();
// testEmployee.DisplayEmployeeDetails();
// testEmployee.firstName = "Test";

// ahmed.DisplayEmployeeDetails();
// testEmployee.DisplayEmployeeDetails();

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
WorkTask task;
task.description = "New Task";
task.hours = 3;
task.PerformWorkTask();
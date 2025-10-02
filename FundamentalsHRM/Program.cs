using System;
using System.Text;
using FundamentalsHRM.Accounting;
using FundamentalsHRM.HR;

#region Simple OOP
//Employee ahmed = new Employee("Ahmed", "Mohamed", "Ahmed@Mohamd.com",DateTime.Parse("12/2/2000"),350, EmployeeType.Manager);


//ahmed.PerformWork(25);

//ahmed.ReciveWage();

//Employee max = new("Max", "Tourest", "Jack@Luck.com", new DateTime(1999, 8, 25), 250, EmployeeType.Research);

// max.PerformWork(40);

//max.ReciveWage();

//WorkTask task;
//task.description = "New Task";
//task.hours = 3;
//task.PerformWorkTask();

//ahmed.PerformWork(30);
//max.PerformWork(35);
//ahmed.DisplayEmployeeDetails();
//max.DisplayEmployeeDetails();

//FundamentalsHRM.Accounting.Customer customer = new FundamentalsHRM.Accounting.Customer();
#endregion
#region GC Test

//List<Employee> employees = new List<Employee>();
//for  (int i = 0; i < 10000000; i++)
//{
//    Employee randomEmployee = new Employee(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),new DateTime(1980,2,19), null, EmployeeType.StoreManager);
//    employees.Add(randomEmployee);
//}
//employees.Clear();
//employees = null;

//GC.Collect();

//Console.ReadLine();
#endregion
#region Record Test
//Account account = new Account("2020202020");
//account.AccountNumber = "7000"; // Error since immutability 

#endregion
#region Arrays
//int[] sampleArray1 = new int[5];

//int[] sampleArray2 = new int[] { 1,2,3,4,5};

//int[] sampleArray3 = new int[5] { 10, 20, 30, 40, 50 };

//Console.WriteLine("How many employees IDs you wan to register?");

//int length = Convert.ToInt32(Console.ReadLine());

//int[] employeeIds = new int[length];
//var testId = employeeIds[0];

//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine("Enter the employee ID: ");
//    int id = Convert.ToInt32(Console.ReadLine());
//    employeeIds[i] = id;
//}

//static void DisplayEmployees(int[] employeeIds)
//{
//    Console.WriteLine("Printing Array");
//    for (int i = 0; i < employeeIds.Length; i++)
//    {
//        Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//    }
//}
//DisplayEmployees(employeeIds);

//Array.Sort(employeeIds);
//DisplayEmployees(employeeIds);

//int[] emplIdsCopy = new int[length];
////Array.Copy(employeeIds, emplIdsCopy, length);
//employeeIds.CopyTo(emplIdsCopy,0);

//Array.Reverse(emplIdsCopy);
//DisplayEmployees(emplIdsCopy);


#endregion
#region Lists
//List<int> employeeIds = new List<int>();

//employeeIds.Add(0);
//employeeIds.Add(1);
//employeeIds.Add(2);
//employeeIds.Add(3);
//employeeIds.Add(4);

////employeeIds.Add("Five");

//if (employeeIds.Contains(30))
//{
//    Console.WriteLine("List contains 30");
//}

//int currentEmployeeCount = employeeIds.Count;

//var employeeIdsArray = employeeIds.ToArray();

//employeeIds.Clear();

//Console.WriteLine("How many employees IDs you wan to register?");

//int length = Convert.ToInt32(Console.ReadLine());

//employeeIds = new List<int>();

//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine("Enter the employee ID: ");
//    int id = Convert.ToInt32(Console.ReadLine());
//    employeeIds.Add(id);
//}


#endregion

#region MoreOOP
IEmployee ahmed = new Employee("Ahmed", "Mohamed", "Ahmed@Mohamd.com", DateTime.Parse("12/2/2000"), 350);

IEmployee max = new Employee("Max", "Tourest", "Jack@Luck.com", new DateTime(1999, 8, 25), 250);

max.PerformWork(8);
max.PerformWork(9);
max.PerformWork();
max.PerformWork();
max.ReciveWage();

IEmployee manager = new Manager("Manager", "manager", "Manager@manager.com", new DateTime(1990, 7, 2), 1000);

manager.PerformWork(30);
manager.ReciveWage();
//manager.AttendManagementMeeting();

JuniorResearcher bobjunior = new JuniorResearcher("Bob", "Spectra", "bob@sunrise.com", new DateTime(2005, 1, 22), 70);

bobjunior.ResearchNewInventions(10);
bobjunior.ResearchNewInventions(10);

IEmployee jake = new Employee("Jake", "Nice", "jack@nice.com", new DateTime(1988, 2, 5), 950, "Old Street", "3", "21202", "Townsvill");
jake.GiveBonus();
manager.GiveBonus();

IEmployee sam = new Manager("Sam", "Heart", "bob@sunrise.com", new DateTime(2005, 1, 22), 70);
IEmployee rell = new Manager("Rell", "Grill", "bob@sunrise.com", new DateTime(2005, 1, 22), 70);
IEmployee simon = new StoreManager("Simon", "Sinek", "bob@sunrise.com", new DateTime(2005, 1, 22), 70);
IEmployee john = new Developer("John", "Wick", "bob@sunrise.com", new DateTime(2005, 1, 22), 70);

List<IEmployee> employees = new List<IEmployee>();
employees.Add(jake);
employees.Add(bobjunior);
employees.Add(sam);
employees.Add(rell);
employees.Add(simon);
employees.Add(john);

foreach (Employee employee in employees)

{
    employee.DisplayEmployeeDetails();
    employee.GiveBonus();
}

rell.GiveBonus();
sam.GiveCompliment();
#endregion
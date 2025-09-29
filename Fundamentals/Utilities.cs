namespace Fundamentals
{
    internal class Utilities
    {
        internal static void ParsingStrings()
        {
            Console.WriteLine("Enter the wage:");
            string? wage = Console.ReadLine();

            //int wageValue = int.Parse(wage);//may fail easy and cause errors

            int wageValue;
            if (int.TryParse(wage, out wageValue))
            {
                Console.WriteLine("Parsing success: " + wageValue);
            }
            else
            {
                System.Console.WriteLine("Parsing failed");
            }

            string hireDataString = "12/08/2022";
            DateTime hireDate = DateTime.Parse(hireDataString);
            Console.WriteLine("Parse data: " + hireDate);
        }
        internal static void UsingStringEquality()
        {
            string name1 = "Mohamed";
            string name2 = "Ahmed";

            Console.WriteLine("Are both names equal? " + (name1 == name2));
            Console.WriteLine("Is name1 equal Mohamed? " + (name1 == "Mohamed"));
            Console.WriteLine("Is name1 equal MOHAMED? " + name1.Equals("MOHAMED"));
            Console.WriteLine("Is lowercase name2 equal to ahmed? " + (name2.ToLower() == "ahmed"));

        }
        internal static void UsingEscapeCharacters()
        {
            string firstName = "Ahmed";
            string lastName = "Mohamed";

            string displayName = $"Welcome!\n{firstName}\t{lastName}";
            Console.WriteLine(displayName);

            string filePath = "C\\data\\employees.xlsx";
            string newFilePath = @"C\data\employees.xlsx";
            string marketingTagLine = "BAcking the \"best meals\" ever";
        }
        internal static void ManipulatingStrings()
        {
            string firstName = "Ahmed";
            string lastName = "Mohamed";

            string fullName = firstName + " " + lastName;
            string employeeIdentification = String.Concat(firstName, lastName);
            string empId = firstName.ToLower() + "-" + lastName.Trim().ToLower();
            int length = empId.Length;
            if (fullName.Contains("ahmed") || fullName.Contains("Ahmed"))
            {
                Console.WriteLine("It is Ahmed");
            }

            string subString = fullName.Substring(1, 6);
            Console.WriteLine("Characters are " + subString);
            string userNameWithInterpolation = $"{firstName}***{lastName}";
        }
        internal static void CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked) => Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
        internal static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            System.Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
    }
}
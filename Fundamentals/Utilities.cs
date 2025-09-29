namespace Fundamentals
{
    internal class Utilities
    {
        internal static void CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked) => Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
        internal static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            System.Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
    }
}
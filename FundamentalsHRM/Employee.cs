// See https://aka.ms/new-console-template for more information
using System;

namespace FundamentalsHRM
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        private const int minimalHoursWorkedUnit = 1;
        public Employee(string fn, string ln, string em, DateTime bd, double rate)
        {
            firstName = fn;
            lastName = ln;
            email = em;
            birthDay = bd;
            hourlyRate = rate;
        }

        public Employee(string fn, string ln, string em, DateTime bd) : this(fn, ln, em, bd, 100)
        {
            
        }

        public void PerformWork()
        {
            //numberOfHoursWorked++;
            PerformWork(minimalHoursWorkedUnit);
            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");

        }
        public int CalculateBonus(int bonus)
        {
            if (numberOfHoursWorked > 10)
                bonus *= 2;
            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        // public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        // {
        //     if (numberOfHoursWorked > 10)
        //         bonus *= 2;

        //     if (bonus >= 200)
        //     {
        //         bonusTax = bonus/10;
        //         bonus -= bonusTax;
        //     }
        //     Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
        //     return bonus;
        // }

        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (numberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus/10;
                bonus -= bonusTax;
            }
            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
            return bonus;
        }
        public double ReciveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work");

            if (resetHours)
                numberOfHoursWorked = 0;

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst Name: \t{firstName}\nLast Name: \t{lastName}\nEmail: \t{email}\nBirthday: \t{birthDay.ToShortDateString()}\n");
        }
    }
}

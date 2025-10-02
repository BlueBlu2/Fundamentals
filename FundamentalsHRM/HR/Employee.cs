// See https://aka.ms/new-console-template for more information
using System;

namespace FundamentalsHRM.HR
{
    internal class Employee : IEmployee
    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate;

        private DateTime birthDay;


        private const int minimalHoursWorkedUnit = 1;
        public static double taxRate = 0.15;

        private Address address;

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }


        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int NumberOfHoursWorked { get => numberOfHoursWorked; protected set => numberOfHoursWorked = value; }
        public double Wage { get => wage; private set => wage = value; }
        public double? HourlyRate
        {
            get => hourlyRate; set
            {
                if (value > 0)
                    hourlyRate = value;
                else
                    hourlyRate = 1;
            }
        }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }


        public Employee(string fn, string ln, string em, DateTime bd, double? rate)
        {
            FirstName = fn;
            LastName = ln;
            Email = em;
            BirthDay = bd;
            HourlyRate = rate??100;

        }

        public Employee(string fn, string ln, string em, DateTime bd) : this(fn, ln, em, bd, 100)
        {
            
        }

        public Employee(string fn, string ln, string em, DateTime bd, double? rate, string street, string houseNumber, string zipCode, string city)
        {
            FirstName = fn;
            LastName = ln;
            Email = em;
            BirthDay = bd;
            HourlyRate = rate ?? 100;
            Address = new Address(street, houseNumber, zipCode, city);
        }

        public void PerformWork()
        {
            //numberOfHoursWorked++;
            PerformWork(minimalHoursWorkedUnit);
            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} {LastName} has worked for {NumberOfHoursWorked} hour(s)!");

        }
        public int CalculateBonus(int bonus)
        {
            if (NumberOfHoursWorked > 10)
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
            if (NumberOfHoursWorked > 10)
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
            
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
            
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{FirstName} {LastName} has received a wage of {Wage} for {NumberOfHoursWorked} hour(s) of work");

            if (resetHours)
                NumberOfHoursWorked = 0;

            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst Name: \t{FirstName}\nLast Name: \t{LastName}\nEmail: \t{Email}\nBirthday: \t{BirthDay.ToShortDateString()}");
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} recived a bonus of 1500!");
        }

        public void GiveCompliment()
        {
            Console.WriteLine($"You have done a great job, {FirstName}");
        }
    }
}

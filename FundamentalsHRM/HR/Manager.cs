// See https://aka.ms/new-console-template for more information
using FundamentalsHRM.HR;

internal class Manager : Employee
{
    public Manager(string fn, string ln, string em, DateTime bd, double? rate) : base(fn, ln, em, bd, rate)
    {
    }

    public void AttendManagementMeeting()
    {
        NumberOfHoursWorked += 10;
        Console.WriteLine($"Manager {FirstName} {LastName} is now in a long meeting!");
    }

    public override void GiveBonus()
    {
        if (NumberOfHoursWorked > 5) 
        {
            Console.WriteLine($"Manager {FirstName} {LastName} recived a management bonus of 3000");
        }
        else
        {
            Console.WriteLine($"Manager {FirstName} {LastName} recived a management bonus of 2000");
        }
    }
}

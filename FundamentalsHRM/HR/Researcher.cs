// See https://aka.ms/new-console-template for more information
using FundamentalsHRM.HR;

internal class Researcher : Employee
{
    public Researcher(string fn, string ln, string em, DateTime bd, double? rate) : base(fn, ln, em, bd, rate)
    {
    }
	protected int numberOfInventionsFinished = 0;

	public int NumberOfInventionsFinished
    {
		get { return numberOfInventionsFinished; }
		set { numberOfInventionsFinished = value; }
	}

	public void ResearchNewInventions(int researchHours)
	{
		NumberOfHoursWorked += researchHours;

		if (new Random().Next(100) > 50)
		{
			NumberOfInventionsFinished++;
			Console.WriteLine($"Researcher {FirstName} {LastName} has done a new invention!\nTotal number of inventions is {NumberOfInventionsFinished}");
		}
		else
		{
            Console.WriteLine($"Research {FirstName} {LastName} is working on a new invention");
		}
	}
}
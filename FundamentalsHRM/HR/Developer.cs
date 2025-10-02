// See https://aka.ms/new-console-template for more information
using FundamentalsHRM.HR;

internal class Developer : Employee
{
	private string currentProject;

	public string CurrentProject
	{
		get { return currentProject; }
		set { currentProject = value; }
	}

	public Developer(string fn, string ln, string em, DateTime bd, double? rate) : base(fn, ln, em, bd, rate)
    {
    }
}

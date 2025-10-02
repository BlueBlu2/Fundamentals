// See https://aka.ms/new-console-template for more information
internal interface IEmployee
{
    double ReciveWage(bool resetHours = true);
    void GiveBonus();
    void PerformWork();
    void PerformWork(int numberOfHoures);
    void DisplayEmployeeDetails();

    void GiveCompliment();

}
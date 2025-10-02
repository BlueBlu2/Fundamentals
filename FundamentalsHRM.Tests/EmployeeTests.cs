using FundamentalsHRM.HR;

namespace FundamentalsHRM.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void PerformWork_Adds_NumberOfHours()
        {
            //Arrange
            Employee employee = new Employee("Zack", "Hack", "zack@hack.com", new DateTime(1999, 7, 12));

            int numberOfHours = 20;
            //Act
            employee.PerformWork(numberOfHours);
            //Assert
            Assert.Equal(numberOfHours, employee.NumberOfHoursWorked);
        }

        [Fact]
        public void PerformWork_Adds_DefaultNumberOfHours_IfNoValueSpecified()
        {
            Employee employee = new Employee("Zack", "Hack", "zack@hack.com", new DateTime(1999, 7, 12));

            employee.PerformWork();

            Assert.Equal(1, employee.NumberOfHoursWorked);
        }
    }
}
namespace OpenClose
{
    public class EmployeeContractor : IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourValue { get; set; }

        public EmployeeContractor(string fullname, int hoursWorked, decimal hourValue = 20000M)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
            HourValue = hourValue;
        }

        public decimal CalculateSalaryMonthly()
        {
            decimal salary = HourValue * HoursWorked;
            return salary;
        }
    }
}
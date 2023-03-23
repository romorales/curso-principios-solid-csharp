namespace OpenClose
{
    public class EmployeeFullTime: IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourValue { get; set; }

        public EmployeeFullTime(string fullname, int hoursWorked, decimal hourValue = 30000M)
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
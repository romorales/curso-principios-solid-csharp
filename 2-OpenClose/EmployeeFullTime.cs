namespace OpenClose
{
    public class EmployeeFullTime: IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourValue { get; set; }

        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
            HourValue = 30000M;
        }

        public EmployeeFullTime(string fullname, int hoursWorked, decimal hourValue)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
            HourValue = hourValue;
        }

        public decimal CalculateSalaryMonthly()
        {
            decimal salary = this.HourValue * this.HoursWorked;
            return salary;
        }
    }
}
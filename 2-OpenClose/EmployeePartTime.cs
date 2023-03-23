namespace OpenClose
{
    public class EmployeePartTime: IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourValue { get; set; }

        public EmployeePartTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
            HourValue = 20000M;
        }

        public EmployeePartTime(string fullname, int hoursWorked, decimal hourValue)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
            HourValue = hourValue;
        }

        public decimal CalculateSalaryMonthly()
        {
           decimal salary = this.HourValue * this.HoursWorked;
            if (this.HoursWorked > 160)
            {
                decimal effortCompensation = 5000M;
                int extraDays = this.HoursWorked - 160;
                salary += effortCompensation * extraDays;
            } 

            return salary;
        }
    }
}
}
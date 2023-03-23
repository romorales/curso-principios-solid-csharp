namespace OpenClose
{
    public class EmployeePartTime: IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourValue { get; set; }

        public EmployeePartTime(string fullname, int hoursWorked, decimal hourValue = 20000M)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
            HourValue = hourValue;
        }

        public decimal CalculateSalaryMonthly()
        {
           decimal salary = HourValue * HoursWorked;
            if (HoursWorked > 160)
            {
                decimal effortCompensation = 5000M;
                int extraDays = HoursWorked - 160;
                salary += effortCompensation * extraDays;
            } 

            return salary;
        }
    }
}
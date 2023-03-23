using System;

namespace OpenClose
{
    public interface IEmployee
    {
        string Fullname { get; set; }
        int HoursWorked { get; set; }

        decimal HourValue { get; set; }

        decimal CalculateSalaryMonthly();
    }
}

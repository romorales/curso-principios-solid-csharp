using OpenClose;

ShowSalaryMonthly(new List<IEmployee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeeFullTime("José Lopez", 160, 40000M),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeePartTime("Juan Morales", 100),
    new EmployeePartTime("Ivan Gonzalez", 180, 13000M),
});


void ShowSalaryMonthly(List<IEmployee> employees) 
{
    foreach (var employee in employees)
    {
        
            Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C1} ");
    }

}
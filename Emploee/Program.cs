namespace Emploee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department sale = new Department("sale");
            sale.AddEmployee(new Employee2());
            sale.AddEmployee(new Employee2());
            sale.AddEmployee(new Employee2());

            Department drivers = new Department("drivers");
            drivers.AddEmployee(new Employee2());
            drivers.AddEmployee(new Employee2());
            drivers.AddEmployee(new Employee2());

            //Console.WriteLine($"Общая сумма зарплаты работников отдела drivers {drivers.GetTotalSalary()}");

            //drivers.PrintDepartmentDetails();
            sale.PrintDepartmentDetails();

        }
    }
}

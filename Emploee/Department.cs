using System;
using System.Collections.Generic;
using System.Text;

namespace Emploee
{
    internal class Department
    {
        public string Name; // название отдела
        private List<Employee2> employees2;
        public Department(string name)
        {
            employees2 = new List<Employee2>();
            Name = name;
        }
        public void AddEmployee(Employee2 employee2)
        {
            employees2.Add(employee2);
            Console.WriteLine("Работник добавлен");
        }

        public void RemoveEmployee(string name)
        {
            int removedCount = employees2.RemoveAll(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (removedCount > 0)
            {
                Console.WriteLine($"Работник '{name}' успешно удалён.");
            }
            else
            {
                Console.WriteLine($"Работник '{name}' не найден.");
            }
        }

        public decimal GetTotalSalary()//считает и возвращает сумму всех зарплат сотрудников отдела
        {
            return employees2.Sum(p => p.Salary);
        }

        public void PrintDepartmentDetails()//выводит название отдела и список всех его работников
        {
            Console.WriteLine($"Отдел {Name}.");

            foreach (Employee2 N in employees2)
            {
                Console.WriteLine($"{N.Name} | {N.Position}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    internal class Restaurant
    {

        public List<Employee> Employees { get; set; }
        public List<string> Menu { get; set; }
        public List<string> Orders { get; set; }
        public decimal DailySales { get; set; }

        public Restaurant()
        {
            Employees = new List<Employee>();
            Menu = new List<string>();
            Orders = new List<string>();
            DailySales = 0;
        }

        // Метод добавления продажи для отчета
        public void AddSale(decimal amount)
        {
            DailySales += amount;
        }

        // Метод вывода отчета
        public void DayReport()
        {
            Console.WriteLine("\n=== Сводка за день ===");

            // Расчет общей зарплаты
            decimal totalSalary = 0;
            foreach (var emp in Employees)
            {
                totalSalary += emp.Salary;
            }

            Console.WriteLine($"Сводка о продажах: {DailySales:C}");
            Console.WriteLine($"Количество обслуженных столиков: {Orders.Count}");
            Console.WriteLine($"Потраченная зарплата: {totalSalary:C}");
            Console.WriteLine("========================");
        }

    }
}

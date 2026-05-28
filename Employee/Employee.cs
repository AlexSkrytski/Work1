using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    internal class Employee
    {

        private string name = string.Empty;
        private string position = string.Empty;

        private decimal salary;
        private decimal bonusAmount;
        public Employee()
        {
            Console.WriteLine("Введите имя сотрудника:");
            name = Console.ReadLine()!;
            Console.WriteLine("Введите должность:");
            position = Console.ReadLine()!;
            Console.WriteLine("Введите зарплату:");
            salary = decimal.Parse(Console.ReadLine()!);
        }
        public void GiveBonus()
        {
            Console.WriteLine("Введите бонус:");
            bonusAmount = decimal.Parse(Console.ReadLine()!);
            salary += bonusAmount;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Зарплата: {salary}");
        }
    }
}

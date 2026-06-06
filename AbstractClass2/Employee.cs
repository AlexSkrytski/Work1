using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass2
{
    public abstract class Employee
    {
        public abstract string Name { get; }
        public decimal BaseSalary { get; }
        public abstract decimal CalculateSalary { get; }
        public Employee(string name, decimal baseSalay)
        {

        }
        public void PrintInfo()

        {

            Console.WriteLine($"Name {Name}, Salary = {CalculateSalary:F2}"); //F2 - округление до 2х знаков
                                                                          
        }

    }
}

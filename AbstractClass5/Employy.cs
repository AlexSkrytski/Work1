using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass5
{
    public abstract class Employy(string name, decimal baseSalary) //Конструктор вариант синтаксиса
    {
        protected string Name = name;

        public decimal BaseSalary = baseSalary;
        public abstract string Position { get; }
        public abstract void CalculateSalary(int workingDays);
    }
}

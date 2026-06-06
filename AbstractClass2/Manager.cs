using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass2
{
    public class Manager : Employee
    {
        public override string Name { get; }
        public decimal Bonus { get; set; }
        public decimal BaseSalary { get; set; }
        public Manager(string name, decimal baseSalary, decimal bonus)
: base(name, baseSalary)
        {
            Name = name;
            
            BaseSalary = baseSalary;

            Bonus = bonus;
        }
        public override decimal CalculateSalary => BaseSalary + Bonus;
        

    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass2
{
    public class Developer : Employee
    {
        public override string Name { get; }
        public decimal BaseSalary { get; set; }
        public decimal ProjectMultiplier { get; set; }
        public Developer(string name, decimal baseSalary, decimal projectMultiplier)
    : base(name, baseSalary)
        {
            Name = name;

            BaseSalary = baseSalary;

            ProjectMultiplier = projectMultiplier;
        }
        public override decimal CalculateSalary => BaseSalary * ProjectMultiplier;

            }
}

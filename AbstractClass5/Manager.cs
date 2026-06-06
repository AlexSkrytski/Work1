using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass5
{
    public class Manager : Employy
    {
        public Manager(string name, decimal baseSalary) : base(name, baseSalary)
        {

        }

        private decimal salary;
        public override string Position => "Менеджер";
        public override void CalculateSalary(int workingDays)
        {
            salary = BaseSalary * workingDays;

            Console.WriteLine($"{Position} {Name} начислено {salary} за {workingDays} рабочих дней.");
        }
    }
}

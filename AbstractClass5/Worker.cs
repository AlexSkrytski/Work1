using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace AbstractClass5
{
    public class Worker:Employy
    {
        public Worker(string name, decimal baseSalary) : base(name, baseSalary)
        {

        }

        private decimal salary;
        public override string Position => "Рабочий";
        public override void CalculateSalary(int workingDays)
        {
            salary = BaseSalary * workingDays * 1.2m;

            Console.WriteLine($"{Position} {Name} начислено {salary} за {workingDays} рабочих дней.");
        }

    }
}

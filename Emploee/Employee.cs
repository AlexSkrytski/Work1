using System;
using System.Collections.Generic;
using System.Text;

namespace Emploee
{
    internal class Employee2
    {
        public string Name;
        public string Position;
        public decimal Salary;

        public Employee2()
        {

            Console.WriteLine("Employee Name:");
            Name = Console.ReadLine()!;

            Console.WriteLine("Position:");
            Position = Console.ReadLine()!;

            Console.WriteLine("Salary:");
            Salary = decimal.Parse(Console.ReadLine()!);

        }
    }



}

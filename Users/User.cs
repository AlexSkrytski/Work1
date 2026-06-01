using System;
using System.Collections.Generic;
using System.Text;

namespace Users
{
    internal class User
    {
        public string name;

        private string _date;

        public string RegistrationDate
        {
            get { return _date; }
            init { _date = value; }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{name}  {RegistrationDate}");
        }

    }
}

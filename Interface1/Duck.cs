using System;
using System.Collections.Generic;
using System.Text;

namespace Interface1
{
    internal class Duck : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Я утка, я лечу!"); ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Interface1
{
    internal class Airplane : IFlyable

    {
        public void Fly()
        {
            Console.WriteLine("Я самолет, я лечу!");
        }
    }
}

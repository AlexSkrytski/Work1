using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass6
{
    public class Gun : Weapon

    {
        public Gun(string name) : base(name)
        {
        }
        public override void Fire()
        {
            Console.WriteLine("Пыщ!"); ;
        }
    }
}

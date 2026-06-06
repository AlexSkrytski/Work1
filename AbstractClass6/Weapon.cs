using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass6
{
    public abstract class Weapon(string name)
    {
        public string Name = name;
        public abstract void Fire();

    }
}

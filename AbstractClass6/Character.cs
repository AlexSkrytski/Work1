using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass6
{
    public abstract class Character(int health)

    {
        public int Health = health;
        public Weapon CurrentWeapon { get; set; }
        public void EquipWeapon(Weapon weapon)
        {
            CurrentWeapon = weapon;
        }
        public abstract void Attack();
    }
}

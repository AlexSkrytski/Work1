using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass6
{
    public class Warrior : Character
    {
        public Warrior(int health) : base(health) { }

        public override void Attack()
        {
            // Проверяем, есть ли оружие
            if (CurrentWeapon != null)
            {
                CurrentWeapon.Fire();
            }
            else
            {
                Console.WriteLine("Бьет кулаками.");
            }
        }
                
    }
}

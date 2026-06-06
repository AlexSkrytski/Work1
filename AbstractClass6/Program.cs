namespace AbstractClass6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior bill = new Warrior(100);

            bill.EquipWeapon(new Gun("Пистоль"));
            
            bill.Attack();
        }
    }
}

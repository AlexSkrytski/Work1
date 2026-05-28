namespace Cafe
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public Employee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }
        public class Waiter : Employee
        {
            public Waiter(string name, decimal salary)
                : base(name, "Официант", salary) { }

            public void TakeOrder(string tableNumber, Order order)
            {
                Console.WriteLine($"{Name} принял заказ от столика №{tableNumber}: {order}.");
            }
        }

        public class Chef : Employee
        {
            public Chef(string name, decimal salary)
                : base(name, "Повар", salary) { }

            public void CookDish(string dish)
            {
                Console.WriteLine($"{Name} готовит блюдо: {dish}.");
            }
        }

    }
}

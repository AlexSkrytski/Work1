namespace InternetShop
{
    internal class Customer
    {
        public string Name = string.Empty;
        public ShoppingCart Cart;
        public Customer(string name)
        {
            Name = name;
           // Cart = new ShoppingCart(); // Инициализация пустой корзины при создании клиента
        }
        public void Buy(ShoppingCart cart)
        {
            var Cart = cart;
            Console.WriteLine($"Customer: {Name}");
            Console.WriteLine("");
            Console.WriteLine("Name | Price");
            decimal total = cart.CalculateTotal();
            //Console.WriteLine(Cart.products[1].name);
            foreach (Product N in Cart.products)
            {
                Console.WriteLine($"{N.name} | {N.price}");
            }
            Console.WriteLine($"Toltal: {total}");

        }

    }
}

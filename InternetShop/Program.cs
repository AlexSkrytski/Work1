namespace InternetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer Bob = new Customer("Bob");
            ShoppingCart cart = new ShoppingCart();
            cart.AddProduct(new Product("Chips", 10));
            cart.AddProduct(new Product("IceCream", 7));
            cart.AddProduct(new Product("BubleGum", 3));
            cart.AddProduct(new Product("Keyboard", 100));

            cart.products.RemoveAll(b => b.name.Equals("Keyboard"));
            //cart.RemoveProduct(cart.products[3]);
            //cart.AddProduct(new Product("Keyboard", 100));
            
            Bob.Buy(cart);



        }
    }
}

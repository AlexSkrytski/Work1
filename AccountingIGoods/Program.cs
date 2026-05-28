namespace AccountingIGoods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warehouse myWarehose = new Warehouse();
            myWarehose.AddProduct(new Product("Chips", 10, 100));
            myWarehose.AddProduct(new Product("IceCream", 7, 110));
            myWarehose.AddProduct(new Product("BubleGum", 3, 200));
            decimal totalValue = myWarehose.GetTotalInventoryValue();
            Console.WriteLine($"Общая стоимость товаров на складе: {totalValue}");
          
        }
    }
}

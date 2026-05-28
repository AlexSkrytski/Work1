using System.Net.Http.Headers;

namespace Cafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dish burger = new Dish("Burger", "fast", 10);
            burger.PrintInfo();

            Dish sushi = new Dish("Sushi", "seafood", 20);
            sushi.PrintInfo();

            Menu myMenu = new Menu();
            myMenu.AddDish(new Dish("Chips", "snack", 5));
            myMenu.AddDish(sushi);
            myMenu.AddDish(burger);
            myMenu.AddDish(new Dish("SeaBass", "seafood", 30));

            //myMenu.RemoveDish("Chips");

            myMenu.ShowMenu();

            Order firstOrder = new Order();
            firstOrder.AddDishToOrder(sushi);
            firstOrder.AddDishToOrder(burger);
            firstOrder.AddDishToOrder(burger);

            firstOrder.PrintReceipt();
        }

    }
}

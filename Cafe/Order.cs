using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Cafe
{
    internal class Order
    {
        public List<Dish> order;
        public Order()
        {
            order = new List<Dish>();
        }

        public void AddDishToOrder(Dish dish)
        {
            order.Add(dish);
            Console.WriteLine("Dish added to order.");
        }
        public decimal CalculateTotal()
        {
            return order.Sum(p => p.price);
        }

        public void PrintReceipt()
        {
            Console.WriteLine("Receipt:");
            foreach (Dish N in order)
            {
                Console.WriteLine($"{N.name} | {N.price}$");
            }

            Console.WriteLine($"Total: {CalculateTotal()}$.");

        }

    }
}

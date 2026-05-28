using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    internal class Dish
    {
        public string name;
        string category;

        public decimal price;

        public Dish(string name, string category, decimal price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Dish name:{name}, price {price}$.");
        }

    }
}

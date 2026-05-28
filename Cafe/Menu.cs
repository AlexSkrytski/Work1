using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Cafe
{
    internal class Menu
    {
        private List<Dish> dishes;
        public Menu()
        {
            dishes = new List<Dish>();
        }
        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
           
        }
        public void RemoveDish(string dishName)
        {
            int removeddish = dishes.RemoveAll(b => b.name.Equals(dishName, StringComparison.OrdinalIgnoreCase));

            if (removeddish > 0)
            {
                Console.WriteLine($"Dish {dishName} removed.");
            }
            else
            {
                Console.WriteLine($"Dish {dishName} didn`t find.");
            }
        }
        public void ShowMenu()
        {
            Console.WriteLine("Caffe menu:");
            foreach (Dish N in dishes)
            {
                Console.WriteLine($"{N.name} | {N.price}");
            }
        }
    }
}

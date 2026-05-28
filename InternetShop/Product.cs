using System;
using System.Collections.Generic;
using System.Text;

namespace InternetShop
{
    internal class Product
    {

        public string name { get; set;}
        public decimal price { get; set;}
        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
    }
}

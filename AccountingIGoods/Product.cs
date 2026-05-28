using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingIGoods
{
    internal class Product
    {
        string name = string.Empty;
        public decimal price;
        public int quantity;

        public Product(string name, decimal price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;

        }


    }
}

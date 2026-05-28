using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingIGoods
{
    internal class Warehouse
    {
        private List<Product> products;
        public Warehouse()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal GetTotalInventoryValue()
        {
            return products.Sum(p => p.price * p.quantity);
        }

    }
}

namespace InternetShop
{
    internal class ShoppingCart
    {
        public List<Product> products;
        public ShoppingCart()
        {
            products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
            
        }
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
        public decimal CalculateTotal()
        {
            return products.Sum(p => p.price);
        }

    }
}

namespace ShoppingCart
{
    public class Cart
    {
        private Dictionary<Product, int> _products;

        public Cart()
        {
            _products = new Dictionary<Product, int>();
        }

        public void AddProduct(Stock stock, Product product, int quantity)
        {
            if (stock.RemoveStock(product, quantity))
            {
                if (_products.ContainsKey(product))
                {
                    _products[product] += quantity;
                }
                else
                {
                    _products.Add(product, quantity);
                }
            }
            else
            {
                Console.WriteLine("Insufficient quantity of product in stock.");
            }
        }
        public void RemoveProduct(Stock stock, Product product, int quantity)
        {
            if (_products[product] == quantity)
            {
                stock.AddStock(product, quantity);
                _products.Remove(product);
            }
            else if (_products[product] > quantity)
            {
                stock.AddStock(product, quantity);
                _products[product] -= quantity;
            }
            else
            {
                Console.WriteLine("Can't remove more product than already in Cart.");
            }
        }
        public Dictionary<Product, int> GetProducts()
        {
            return _products;
        }
    }
}

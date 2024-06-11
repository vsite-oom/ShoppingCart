namespace ShoppingCart
{
    public class Stock
    {
        private Dictionary<Product, int> _products;
        public IReadOnlyDictionary<Product, int> Products { get { return _products; } }

        public Stock()
        {
            _products = new Dictionary<Product, int>();
        }

        public void AddStock(Product product, int quantity)
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
        public bool RemoveStock(Product product, int quantity)
        {
            if (_products.ContainsKey(product) && _products[product] >= quantity)
            {
                _products[product] -= quantity;
                return true;
            }
            return false;
        }
    }
}

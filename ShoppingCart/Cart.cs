namespace ShoppingCart
{
    public class Cart
    {
        private Dictionary<Product, int> _shoppingProducts;

        public Cart()
        {
            _shoppingProducts = new Dictionary<Product, int>();
        }

        public void AddToCart(Stock stock, Product product, int productCount = 1)
        {
            if (stock.RemoveProduct(product, productCount)) {
                if (_shoppingProducts.ContainsKey(product))
                {
                    _shoppingProducts[product] += productCount;   
                }
                else _shoppingProducts.Add(product, productCount);
            }
        }

        public Dictionary<Product, int> GetCartProducts()
        {
            return _shoppingProducts;
        }

        public void Clear()
        {
            _shoppingProducts.Clear();
        }

        public void ListAllProducts()
        {
            foreach(var product in _shoppingProducts)
            {
                Console.WriteLine($"Proizvod: {product.Key.GetName()}, količina: {product.Value}");
            }
        }

    }
}

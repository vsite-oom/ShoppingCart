namespace ShoppingCart
{
    public class Cart
    {
        private Dictionary<Product, int> _items;

        public Cart()
        {
            _items = new Dictionary<Product, int>();
        }

        public void AddToCart(Stock stock, Product product, int count = 1)
        {
            if(stock.RemoveProduct(product, count))
            {   
                if(_items.ContainsKey(product))
                {
                    _items[product] += count;
                }
                else
                {
                    _items.Add(product, count);
                }
            }
        }

        public Dictionary<Product, int> GetItems()
        {
            return _items;
        }

        public void ListAllProducts()
        {
            foreach(var item in _items)
            {
                Console.WriteLine($"{item.Key.GetName()}: {item.Value}");
            }
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}

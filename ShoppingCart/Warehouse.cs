using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Warehouse
    {
        private readonly Dictionary<Product, int> _stock = [];

        public void AddProduct(Product product, int quantity)
        {
            if (!_stock.TryAdd(product, quantity))
            {
                _stock[product] += quantity;
            }
        }

        public void RemoveProduct(Product product, int quantity)
        {
            if (_stock.TryGetValue(product, out int value))
            {
                if (value <= quantity)
                {
                    _stock.Remove(product);
                }
                else
                {
                    _stock[product] -= quantity;
                }
            }
        }
        public bool IsAvailable(Product product, int quantity)
        {
            if (_stock.TryGetValue(product, out int value))
            {
                return value >= quantity;
            }
            return false;
        }
    }
}

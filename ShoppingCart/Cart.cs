using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Cart
    {
        private readonly Dictionary<Product, int> _products = [];
        public bool IsEmpty() => _products.Count == 0;

        public Dictionary<Product, int> GetProducts()
        {
            return new Dictionary<Product, int>(_products);
        }
        public void AddProduct(Product product, int quantity)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(quantity);

            if (!_products.TryAdd(product, quantity))
            {
                _products[product] += quantity;
            }
        }
        public void RemoveProduct(Product product, int quantity)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(quantity);

            if (_products.TryGetValue(product, out int value))
            {
                if (value <= quantity)
                {
                    _products.Remove(product);
                }
                else
                {
                    _products[product] -= quantity;
                }
            }
        }

        public void Clear()
        {
            _products.Clear();
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var product in _products)
            {
                totalPrice += product.Key.Price * product.Value;
            }
            return totalPrice;
        }

    }
}

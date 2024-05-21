using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Pricelist
    {
        private readonly Dictionary<Product, decimal> _pricelist = [];

        public Dictionary<Product, decimal> GetProducts()
        {
            return new Dictionary<Product, decimal>(_pricelist);
        }
        public void AddProduct(Product product, decimal price)
        {
            if (!_pricelist.TryAdd(product, price))
            {
                _pricelist[product] = price;
            }
        }

        public decimal GetPrice(Product product)
        {
            return _pricelist[product];
        }
    }
}

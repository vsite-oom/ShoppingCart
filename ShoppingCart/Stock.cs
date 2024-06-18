using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Stock
    {
        public List<Product> Products { get; set; }

        public Stock()
        {
            Products = new List<Product>();
        }

        public void AddProduct(string name, decimal price)
        {
            Products.Add(new Product(name, price));
        }

        public void RemoveProduct(string name)
        {
            Products.RemoveAll(x => x.Name == name);
        }

        public void UpdatePrice(string name, decimal price)
        {
            var product = Products.FirstOrDefault(x => x.Name == name);
            if (product != null)
            {
                product.Price = price;
            }
        }

        public decimal GetPrice(string name)
        {
            var product = Products.FirstOrDefault(x => x.Name == name);
            return product?.Price ?? 0;
        }
    }
}

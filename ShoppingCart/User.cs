using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class User
    {
        private readonly Cart _cart = new();

        public int Id { get; set; }
        public required string Name { get; set; }

        public Dictionary<Product, int> GetCart()
        {
            return _cart.GetProducts();
        }
        public void AddToCart(Product product, int quantity)
        {
            _cart.AddProduct(product, quantity);
        }
        public void RemoveFromCart(Product product, int quantity)
        {
            _cart.RemoveProduct(product, quantity);
        }

        public void ClearCart()
        {
            _cart.Clear();
        }

        public decimal GetCartValue()
        {
            return _cart.GetTotalPrice();
        }
    }
}

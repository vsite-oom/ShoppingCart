using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class CashRegister
    {
        public Cart Cart { get; set; }

        public CashRegister()
        {
            Cart = new Cart();
        }

        public void AddProduct(string name, decimal price, int quantity)
        {
            var product = new Product(name, price);
            Cart.AddItem(product, quantity);
        }

        public void RemoveProduct(string name)
        {
            var product = new Product(name, 0);
            Cart.RemoveItem(product);
        }

        public void UpdateQuantity(string name, int quantity)
        {
            var product = new Product(name, 0);
            Cart.UpdateQuantity(product, quantity);
        }

        public decimal GetTotal()
        {
            return Cart.GetTotal();
        }
    }
}

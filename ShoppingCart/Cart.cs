using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Cart
    {
        public List<CartItem> Items { get; set; }

        public Cart()
        {
            Items = new List<CartItem>();
        }

        public void AddItem(Product product, int quantity)
        {
            Items.Add(new CartItem(product, quantity));
        }

        public void RemoveItem(Product product)
        {
            Items.RemoveAll(x => x.Product == product);
        }

        public void UpdateQuantity(Product product, int quantity)
        {
            var item = Items.FirstOrDefault(x => x.Product == product);
            if (item != null)
            {
                item.Quantity = quantity;
            }
        }

        public decimal GetTotal()
        {
            return Items.Sum(x => x.Product.Price * x.Quantity);
        }
    }
}

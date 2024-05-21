using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Store
    {
        private readonly Pricelist _pricelist;
        private readonly Warehouse _warehouse;

        public Store(Pricelist pricelist, Warehouse warehouse)
        {
            _pricelist = pricelist;
            _warehouse = warehouse;
        }

        public Dictionary<Product, decimal> GetProducts()
        {
            return _pricelist.GetProducts();
        }
        public Product GetProductById(int id)
        {
            return _pricelist.GetProducts().FirstOrDefault(x => x.Key.Id == id).Key;
        }

        public void AddStock(Product product, int quantity)
        {
            _warehouse.AddProduct(product, quantity);
        }
        public void RemoveStock(Product product, int quantity)
        {
            _warehouse.RemoveProduct(product, quantity);
        }

        public bool IsProductAvailable(Product product, int quantity)
        {
            return _warehouse.IsAvailable(product, quantity);
        }
    }
}

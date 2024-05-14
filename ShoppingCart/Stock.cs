namespace ShoppingCart
{
    public class Stock
    {
        private Dictionary<Product, int> products = new Dictionary<Product, int>();

        public void AddToStock(Product item, int count = 1)
        {
            //int id = item.GetId();
            if(products.ContainsKey(item))
            {
                products[item] += count;
            }
            else
            {
                products.Add(item, count);
            }
        }

        public bool RemoveProduct(Product item, int count)
        {
            if (products.ContainsKey(item) && products[item] >= count) 
            {
                products[item] -= count;
                if (products[item] == 0) products.Remove(item);
                return true;
            }
            return false;
        }

        public bool StockContains(Product item)
        {
            return products.ContainsKey(item);
        }

        public int StockItemAmount(Product item)
        {
            return products[item];
        }
    }
}
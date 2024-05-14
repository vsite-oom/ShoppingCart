namespace ShoppingCart
{
    public class Stock
    {
        private Dictionary<int, uint> products;

        public Stock()
        {
            products = new Dictionary<int, uint>();
        }
        public void AddToStock(Product product, uint numberOfItems = 1)
        {
            int id = product.GetId();
            products[id] += numberOfItems;
        }

        public bool RemoveProduct(int id)
        {
            if (products.ContainsKey(id))
            {
                products[id]--;
                if (products[id] == 0) products.Remove(id);
                return true;
            }
            return false;
        }
    }
}
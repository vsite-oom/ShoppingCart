namespace ShoppingCart
{
    public class Stock
    {
        private Dictionary<Product, int> products;

        public Stock()
        {
            products = new Dictionary<Product, int>();
        }

        public void AddToStock(Product product, int numberOfItems = 1)
        {
            int id = product.GetId();
            if (products.ContainsKey(product))
            {
                products[product] += numberOfItems;
            }
            else products.Add(product, numberOfItems);
            
        }

        public bool Contains(Product product)
        {
            return products.ContainsKey(product);
        }

        public int GetNumberOfItems(Product product)
        {
            return products[product];
        }

        public bool RemoveProduct(Product product, int numberOfProducts = 1)
        {
            int id = product.GetId();
            if (products.ContainsKey(product) && products[product] >= numberOfProducts)
            {
                products[product] -= numberOfProducts;
                if (products[product] == 0) products.Remove(product);
                return true;
            }
            return false;
        }
    }
}
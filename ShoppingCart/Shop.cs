namespace ShoppingCart
{
    public class Shop
    {
        private readonly string name;
        private IEnumerable<Article> articles;
        private Warehouse warehouse;

        public Shop(string name)
        {
            this.name = name;
            warehouse = new Warehouse();
            this.articles = new List<Article>();
        }

        public int AddItem(Article item, int quantity)
        {
            articles.Append(item);
            warehouse.AddItemToWarehouse(item, quantity);
            throw new NotImplementedException();
        }

        public int RemoveItem(Article item, int quantity)
        {
            if (warehouse.SearchForItem(item) >= quantity)
            {
                return warehouse.RemoveItemFromWarehouse(item, quantity);
            }
            else
                return -1;
        }

        public Article GetItems()
        {
            throw new NotImplementedException();
        }

        public int Checkout()
        {
            throw new NotImplementedException();
        }
    }
}

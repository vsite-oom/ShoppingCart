namespace ShoppingCart
{
    public class Warehouse
    {
        private Dictionary<Article, int> itemsInWarehouse;

        public Warehouse()
        {
            itemsInWarehouse = new Dictionary<Article, int>();
        }

        public int Count { get {  return itemsInWarehouse.Count; } }
        public int SearchForItem(Article item)
        {
            return itemsInWarehouse.FirstOrDefault(i => i.Key.Equals(item.ToString())).Value;
        }

        public int AddItemToWarehouse(Article item, int count)
        {
            if(itemsInWarehouse.ContainsKey(item) == false)
            {
                itemsInWarehouse[item] = count;
            }
            else
            {
                itemsInWarehouse[item] += count;
            }

            return itemsInWarehouse[item];
        }

        public int RemoveItemFromWarehouse(Article item, int count)
        {
            itemsInWarehouse[item] -= count;

            return itemsInWarehouse[item];
        }
    }
}

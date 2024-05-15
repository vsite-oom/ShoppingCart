namespace ShoppingCart
{
    public class ShopingCart
    {
        private Dictionary<Article, int> itemsInCart;

        public ShopingCart() 
        {
            itemsInCart = new Dictionary<Article, int>();
        }

        public void AddArticle(Article article, int count)
        {

            itemsInCart.Add(article, count);
        }

        public void RemoveArticle(Article article, int count)
        {
            itemsInCart.Remove(article);
        }
    }
}

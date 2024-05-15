namespace ShoppingCart
{
    public class Article
    {
        private static int id = 0;
        private readonly string name;

        public Article(int id, string name)
        {
            this.name = name;
            id += 1;
        }


    }
}

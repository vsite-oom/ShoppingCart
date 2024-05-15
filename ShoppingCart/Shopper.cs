namespace ShoppingCart
{
    public class Shopper
    {
        private readonly string firstName;
        private readonly string lastName;
        private static int id = 0;
        private ShopingCart shopingCart = new ShopingCart();

        public Shopper(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            id += 1;
        }

        public static int Id { get { return id; } }

    }
}

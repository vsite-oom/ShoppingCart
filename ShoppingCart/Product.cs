namespace ShoppingCart
{
    public class Product
    {
        private static int productId = 0;
        private int _id = 0;
        private string _name;
        private double _price;

        public Product(string name, double price)
        {
            _id = productId; productId++;
            _name = name;
            _price = price;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}
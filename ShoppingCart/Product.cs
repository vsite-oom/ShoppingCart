namespace ShoppingCart
{
    public class Product
    {
        private readonly int _id;
        private readonly string _name;
        private readonly double _price;
        public string Name => _name;
        public double GetPrice => _price;

        private static int _instanceId = 0;

        public Product(string name, double price)
        {
            _id = ++_instanceId;
            _name = name;
            _price = price;
        }
    }
}

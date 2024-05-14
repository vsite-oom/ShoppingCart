namespace ShoppingCart
{
    public class Product
    {
        private static int _productId = 0;
        private int _id;
        private string _name;
        private double _price;

        public Product( string name, double price)
        {
            _id = _productId;
            _productId++;
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
namespace ShoppingCart
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;

        public Product(int id, string name, double price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public int GetId()
        {
            return _id;
        }
    }
}
namespace ShoppingCart
{
    public class CashRegister
    {
        private int _id;
        private double _amount;

        private static int _instanceID = 0;

        public CashRegister()
        {
            _id = ++_instanceID;
            _amount = 0;
        }

        public double CalculateAmount(Cart cart)
        {
            var products = cart.GetProducts();
            foreach (var product in products)
            {
                _amount += product.Key.GetPrice() * product.Value;
            }
            return _amount;
        }
    }
}

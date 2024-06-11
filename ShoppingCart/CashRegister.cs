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
            Console.WriteLine("Items in cart:");
            var products = cart.GetProducts();
            foreach (var product in products)
            {
                var price = product.Key.GetPrice * product.Value;
                _amount += price;
                Console.WriteLine($"Proizvod: {product.Key}; Cijena: {product.Key.GetPrice}; Komada: {product.Value}");
                Console.WriteLine($"Suma proizvoda: {price:f2}");
            }
            return _amount;
        }
    }
}

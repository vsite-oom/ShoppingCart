namespace ShoppingCart
{
    public class CashRegister
    {
        private static int _receiptNumbers = 0;
        private int _receiptNumber = 0;
        private double _amount;

        public CashRegister()
        {
            _receiptNumber = _receiptNumbers;
            _receiptNumbers++;
        }

        public double GetAmount(Cart cart)
        {
            var cartProducts = cart.GetCartProducts();
            foreach (var product in cartProducts)
            {
                _amount += product.Key.GetPrice() * product.Value;
            }
            cart.Clear();
            return _amount;
        }
        
    }
}

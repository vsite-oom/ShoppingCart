namespace ShoppingCart
{
    public class CashRegister
    {
        private int receiprNbr = 0;
        private static int invoiceN = 0;
        private double amount;


        public CashRegister()
        {
            receiprNbr = invoiceN; invoiceN++;
            Console.WriteLine($"Amount: {amount} €.");
        }

        public double Calculate(Cart cart)
        {
            var _items = cart.GetItems();
            foreach(var item in _items)
            {
                amount = item.Key.GetPrice() * item.Value;
            }
            cart.Clear();
            return amount;
        } 
    }
}

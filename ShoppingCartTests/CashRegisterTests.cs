namespace ShoppingCart.Tests
{
    [TestClass]
    public class CashRegisterTests
    {
        [TestMethod]
        public void TestReceiptAmount()
        {
            var cart = new Cart();
            var stock = new Stock();
            var vino = new Product("vino", 3);
            var voda = new Product("voda", 1);
            stock.AddToStock(vino, 200);
            stock.AddToStock(voda, 200);

            cart.AddToCart(stock, vino, 12);
            cart.AddToCart(stock, voda, 14);

            var cashRegister = new CashRegister();

            Assert.AreEqual(50, cashRegister.GetAmount(cart));
            Assert.AreEqual(0, cart.GetCartProducts().Count);
        }
    }
}
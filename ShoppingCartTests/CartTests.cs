namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void TestCartItemsCount()
        {
            var cart = new Cart();
            var stock = new Stock();
            var vino = new Product("vino", 4.56);
            var voda = new Product("voda", 1.23);
            stock.AddToStock(vino, 200);
            stock.AddToStock(voda, 200);

            cart.AddToCart(stock, vino, 143);
            cart.AddToCart(stock, voda, 12);

            Assert.AreEqual(155, cart.GetCartProducts().Values.Sum());

        }

        [TestMethod]
        public void TestCartClearItems() {
            var cart = new Cart();
            var stock = new Stock();
            var vino = new Product("vino", 4.56);
            var voda = new Product("voda", 1.23);
            stock.AddToStock(vino, 200);
            stock.AddToStock(voda, 200);

            cart.AddToCart(stock, vino, 143);
            cart.AddToCart(stock, voda, 12);

            Assert.AreEqual(2, cart.GetCartProducts().Count);

            cart.Clear();

            Assert.AreEqual(0, cart.GetCartProducts().Count);
        }
    }
}
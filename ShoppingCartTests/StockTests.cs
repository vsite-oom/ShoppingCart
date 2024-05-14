namespace ShoppingCart.Tests
{
    [TestClass]
    public class StockTests
    {
        [TestMethod]
        public void TestStockContainingElement()
        {
            var stock = new Stock();

            var vino = new Product("Plavac", 5.76);
            stock.AddToStock(vino, 758);

            Assert.IsTrue(stock.Contains(vino));
        }

        [TestMethod]
        public void TestStockNumberOfItems()
        {
            var stock = new Stock();

            var vino = new Product("Plavac", 5.76);
            stock.AddToStock(vino, 758);

            Assert.AreEqual(758, stock.GetNumberOfItems(vino));
        }

        [TestMethod]
        public void TestStockRemoveItemsWhenThereIsEnoughItems()
        {
            var stock = new Stock();
            var product = new Product("vino", 4.56);

            stock.AddToStock(product, 456);
            stock.RemoveProduct(product, 426);

            Assert.AreEqual(30, stock.GetNumberOfItems(product));
        }
        [TestMethod]
        public void TestStockRemoveItemsWhenThereIsNotEnoughItems()
        {
            var stock = new Stock();
            var product = new Product("vino", 4.56);

            stock.AddToStock(product, 456);
            stock.RemoveProduct(product, 476);

            Assert.IsTrue(stock.Contains(product));
        }

        [TestMethod]
        public void TestStockRemoveItemsWhenThereIsExactlyEnoughItems()
        {
            var stock = new Stock();
            var product = new Product("vino", 4.56);

            stock.AddToStock(product, 456);
            stock.RemoveProduct(product, 456);

            Assert.IsFalse(stock.Contains(product));
        }
    }
}
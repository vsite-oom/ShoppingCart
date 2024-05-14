namespace ShoppingCart.Tests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void TestProductIdAutoincrement()
        {
            var cola = new Product("Coca-cola", 2.99);
            var voda = new Product("Jana", 1.20);

            Assert.AreEqual(0, cola.GetId());
            Assert.AreEqual(1, voda.GetId());
        }

        [TestMethod]
        public void TestProductsGetters()
        {
            var product = new Product("Kifla", 0.67);

            Assert.AreEqual("Kifla", product.GetName());
            Assert.AreEqual(0.67, product.GetPrice());
        }
    }
}
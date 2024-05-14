namespace ShoppingCart.Tests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void TestIdAutoincrement()
        {
            var product1 = new Product("Jana", 1.25);
            var product2 = new Product("Kruh Bijeli", 1.0);

            Assert.AreEqual(0, product1.GetId());
            Assert.AreEqual(1, product2.GetId());
        }

        [TestMethod]
        public void TestProductGetters()
        {
            var pro = new Product("Vatromet", 5.60);

            Assert.AreEqual("Vatromet", pro.GetName());
            Assert.AreEqual(5.60, pro.GetPrice());
            Assert.AreEqual(2, pro.GetId());
        }
    }
}
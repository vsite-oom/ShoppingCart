using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class StockTests
    {
        [TestMethod]
        public void TestAddingToStock()
        {
            var stock = new Stock();
            var pro = new Product("kruh", 0.8);

            Assert.IsFalse(stock.StockContains(pro));

            stock.AddToStock(pro);

            Assert.IsTrue(stock.StockContains(pro));
        }

        [TestMethod]
        public void TestCountOfItemInStock()
        {
            var stock = new Stock();
            var pro = new Product("kruh", 0.8);
            var pro2 = new Product("tikva", 2.5);

            stock.AddToStock(pro, 5);
            stock.AddToStock(pro2, 404);

            Assert.AreEqual(5, stock.StockItemAmount(pro));
            Assert.AreEqual(404, stock.StockItemAmount(pro2));
        }

        [TestMethod]
        public void TestRemoveItems()
        {
            var stock = new Stock();
            var pro = new Product("kruh", 0.8);
            var pro2 = new Product("tikva", 2.5);

            stock.AddToStock(pro, 5);
            stock.AddToStock(pro2, 404);

            stock.RemoveProduct(pro, 2);
            Assert.AreEqual(3, stock.StockItemAmount(pro));

            stock.RemoveProduct(pro2, 500);
            Assert.AreEqual(404, stock.StockItemAmount(pro2));
        }
    }
}
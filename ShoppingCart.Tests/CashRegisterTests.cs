using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CashRegisterTests
    {
        [TestMethod]
        public void CalculateSummationOfACart()
        {
            var cart = new Cart();
            var stock = new Stock();
            var prod = new Product("čaj", 2.33);
            var pro = new Product("kruh", 1);
            var pro2 = new Product("tikva", 2.5);

            stock.AddToStock(prod, 105);
            stock.AddToStock(pro, 555);
            stock.AddToStock(pro2, 404);

            cart.AddToCart(stock, pro, 3);
            var blag = new CashRegister();

            Assert.AreEqual(3, blag.Calculate(cart));
            Assert.AreEqual(0, cart.GetItems().Count());

            cart.AddToCart(stock, pro2, 4);
            Assert.AreEqual(10, blag.Calculate(cart));
        }
    }
}
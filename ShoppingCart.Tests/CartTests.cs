using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void TestItemCount()
        {
            var cart = new Cart();
            var stock = new Stock();
            var prod = new Product("čaj", 2.33);
            stock.AddToStock(prod, 105);

            cart.AddToCart(stock, prod);

            Assert.AreEqual(1, cart.GetItems().Values.Sum());
            
            cart.AddToCart(stock, prod, 5);

            Assert.AreEqual(6, cart.GetItems().Values.Sum());
        }
        
        
        [TestMethod]
        public void TestClearCart()
        {
            var cart = new Cart();
            var stock = new Stock();
            var prod = new Product("čaj", 2.33);
            stock.AddToStock(prod, 105);

            cart.AddToCart(stock, prod, 30);
            Assert.AreEqual(30, cart.GetItems().Values.Sum());

            cart.Clear();
            Assert.AreEqual(0, cart.GetItems().Values.Sum());
        }
    }
}
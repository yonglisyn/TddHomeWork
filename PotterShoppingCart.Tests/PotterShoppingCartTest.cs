using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart.Tests.Models;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class PotterShoppingCartTest
    {
        [TestMethod]
        public void Test_CalculatePrice_Buy_1_Book_Should_Be_100()
        {
            var version = 1;
            var book = new Potter(version);
            var shopCart = new ShoppingCart(book);
            var expected = 100;
            var actualPrice = shopCart.GetPrice();
            Assert.AreEqual(expected,actualPrice);
        }

        [TestMethod]
        public void Test_CalculatePrice_Buy_1_Book1_1_Book2_Should_Be_190()
        {
            var books = new List<Potter>{new Potter(1), new Potter(2)};
            var shopCart = new ShoppingCart(books);
            var expected = 190;
            var actualPrice = shopCart.GetPrice();
            Assert.AreEqual(expected,actualPrice);
        }
    }
}

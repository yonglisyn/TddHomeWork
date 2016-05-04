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
            var books = new List<Potter>{new Potter(version)};
            var shopCart = new ShoppingCart(books);
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

        [TestMethod]
        public void Test_CalculatePrice_Buy_1_Book1_1_Book2_1_Book3_Should_Be_270()
        {
            var books = new List<Potter>{new Potter(1),new Potter(2),new Potter(3)};
            var shopCart = new ShoppingCart(books);
            var expected = 270;
            var actualPrice = shopCart.GetPrice();
            Assert.AreEqual(expected, actualPrice);
        }
        [TestMethod]
        public void Test_CalculatePrice_Buy_1_Book1_1_Book2_1_Book3_1_Book4_Should_Be_320()
        {
            var books = new List<Potter>{new Potter(1),new Potter(2),new Potter(3),new Potter(4)};
            var shopCart = new ShoppingCart(books);
            var expected = 320;
            var actualPrice = shopCart.GetPrice();
            Assert.AreEqual(expected, actualPrice);
        }

        [TestMethod]
        public void Test_CalculatePrice_Buy_WholeSet_Should_Be_375()
        {
            var books = new List<Potter>{new Potter(1),new Potter(2),new Potter(3),new Potter(4),new Potter(5)};
            var shopCart = new ShoppingCart(books);
            var expected = 375;
            var actualPrice = shopCart.GetPrice();
            Assert.AreEqual(expected, actualPrice);
        }
    }
}

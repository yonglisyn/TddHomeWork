using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }

    public class ShoppingCart
    {
        private Potter _Book;

        public ShoppingCart(Potter book)
        {
            _Book = book;
        }

        public int GetPrice()
        {
            return _Book.Price;
        }
    }

    public class Potter
    {
        private int _Version;
        private const int _Price = 100;
        public Potter(int version)
        {
            _Version = version;
        }

        public int Price { get { return _Price; }}
    }
}

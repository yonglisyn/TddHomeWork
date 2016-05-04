using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart.Tests.Models
{
    public class ShoppingCart
    {
        private List<Potter> _Books;

        public ShoppingCart(List<Potter> books)
        {
            _Books = books;
        }

        public int GetPrice()
        {
            return Convert.ToInt16(_Books.Sum(x=>x.Price)* (1 - Discount()));
        }

        private double Discount()
        {
            if (_Books.Count == 2)
                return 0.05;
            if (_Books.Count == 3)
                return 0.1;
            return 0;
        }
    }
}
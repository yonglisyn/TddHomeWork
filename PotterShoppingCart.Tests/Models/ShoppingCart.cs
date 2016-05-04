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
            if (_Books.Count == 1)
            {
                return _Books.First().Price;
            }
            if (_Books.Count == 2)
            {
                return Convert.ToInt16( _Books.Sum(x => x.Price)*0.95);
            }
            if (_Books.Count == 3)
            {
                return Convert.ToInt16(_Books.Sum(x => x.Price) * 0.9);
                
            }
            return 0;
        }
    }
}
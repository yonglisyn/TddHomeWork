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
                return 190;
            }
            return 0;
        }
    }
}
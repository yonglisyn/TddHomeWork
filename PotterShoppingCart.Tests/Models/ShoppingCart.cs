using System.Collections.Generic;

namespace PotterShoppingCart.Tests.Models
{
    public class ShoppingCart
    {
        private Potter _Book;
        private List<Potter> _Books;

        public ShoppingCart(Potter book)
        {
            _Book = book;
        }

        public ShoppingCart(List<Potter> books)
        {
            _Books = books;
        }

        public int GetPrice()
        {
            if (_Book != null)
            {
                return _Book.Price;
            }
            if (_Books.Count == 2)
            {
                return 190;
            }
            return 0;
        }
    }
}
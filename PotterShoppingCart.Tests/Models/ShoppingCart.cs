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
            return _Book.Price;
        }
    }
}
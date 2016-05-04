namespace PotterShoppingCart.Tests.Models
{
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
}
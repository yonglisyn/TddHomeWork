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
            var discountableBooks = _Books.GroupBy(x => x.Version).Select(y => y.First()).ToList();
            var priceOfDiscountableBooks = Convert.ToInt16(discountableBooks.Sum(x => x.Price) * (1 - Discount(discountableBooks)));

            var secondDiscountableBooks = _Books.GroupBy(x => x.Version).Where(g=>g.Count()==2).Select(y => y.First()).ToList();
            var priceOfsecondDiscountableBooks = Convert.ToInt16(secondDiscountableBooks.Sum(x => x.Price) * (1 - Discount(secondDiscountableBooks)));

            var nonDiscountableBooks = _Books.GroupBy(x => x.Version).Where(y => y.Count() > 2).ToList();
            var priceOfNonDiscountalbeBooks = nonDiscountableBooks.Count * 100;
            return priceOfDiscountableBooks + priceOfNonDiscountalbeBooks + priceOfsecondDiscountableBooks;
        }

        private double Discount(IEnumerable<Potter> distinctBooks)
        {
            switch (distinctBooks.Select(x => x.Version).Count())
            {
                case 2:
                    return 0.05;
                case 3:
                    return 0.1;
                case 4:
                    return 0.2;
                case 5:
                    return 0.25;
                default:
                    return 0;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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
            var distinctPrice = Convert.ToInt16(discountableBooks.Sum(x => x.Price) * (1 - Discount(discountableBooks)));
            var nonDiscountableBooks = _Books.GroupBy(x => x.Version).Where(y => y.Count() > 1).ToList();
            var duplicatedPrice = nonDiscountableBooks.Count * 100;
            return distinctPrice + duplicatedPrice;
        }

        private double Discount(IEnumerable<Potter> distinctBooks)
        {
            switch (distinctBooks.Select(x => x.Version).Distinct().Count())
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
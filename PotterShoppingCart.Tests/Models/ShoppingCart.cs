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
            var booksGroups = _Books.GroupBy(x => x.Version);
            var maxGroupCount = booksGroups.Max(x => x.Count());
            var groupCount = 0;
            var price = 0;
            while (groupCount < maxGroupCount)
            {
                var myBooks = GetDistinctBooksForCountOfSameVersion(groupCount);
                price += Convert.ToInt16(myBooks.Sum(x => x.Price) * (1 - Discount(myBooks)));
                groupCount++;
            }
            return price;
        }

        private List<Potter> GetDistinctBooksForCountOfSameVersion(int groupCount)
        {
            return _Books.GroupBy(x => x.Version).Where(y => y.Count() > groupCount).Select(x => x.FirstOrDefault()).ToList();
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
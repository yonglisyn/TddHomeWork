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
            switch (_Books.Count)
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
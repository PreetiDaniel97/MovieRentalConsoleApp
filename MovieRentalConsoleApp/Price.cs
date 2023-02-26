using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalConsoleApp
{
    public abstract class Price
    {
        public abstract string getPriceCode();

        public abstract double getCharge(int daysRented);

        public int getFrequentRenterPoints(int daysRented)
        {
            return 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalConsoleApp
{
    public class NewReleasePrice: Price
    {
        public override string getPriceCode()
        {
            return "NEW_RELEASE";
        }

        public override double getCharge(int daysRented)
        {
            return daysRented * 3;
        }
        public int getFrequentRenterPoints(int daysRented)
        {
            if (daysRented > 1)
                return 2;
            return 1;
        }
    }
}

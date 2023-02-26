using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalConsoleApp
{
    public class RegularPrice:Price
    {
        public override string getPriceCode()
        {
            return "REGULAR";
        }

        public override double getCharge(int daysRented)
        {
            double amount = 2;
            if (daysRented > 2)
                amount += (daysRented - 2) * 1.5;
            return amount;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalConsoleApp
{
    public class ChildrensPrice: Price
    {
        public override string getPriceCode()
        {
            return "CHILDREN";
        }

        public override double getCharge(int daysRented)
        {
            double amount = 1.5;
            if (daysRented > 3)
                amount += (daysRented - 3) * 1.5;
            return amount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalConsoleApp
{
   public  class Movie
    {
        private String title;
        Price price;

        public Movie(String title, string priceCode)
        {
            this.title = title;
            setPriceCode(priceCode);
        }
        public String getTitle()
        {
            return title;
        }
        private void setPriceCode(string priceCode)
        {
            switch (priceCode)
            {
                case "CHILDREN":
                    price = new ChildrensPrice();
                    break;
                case "NEW_RELEASE":
                    price = new NewReleasePrice();
                    break;
                case "REGULAR":
                    price = new RegularPrice();
                    break;
                default:
                    throw new Exception("");
            }
        }
        public string getPriceCode()
        {
            return price.getPriceCode();
        }
        public double getCharge(int daysRented)
        {
            return price.getCharge(daysRented);
        }
        public int getFrequentRenterPoints(int daysRented)
        {
            return price.getFrequentRenterPoints(daysRented);
        }
    }
}

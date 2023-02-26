using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalConsoleApp
{
    public class Customer
    {
        private String name;
        private List<Rental> rentals = new List<Rental>();

        public Customer(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public void addRental(Rental rental)
        {
            rentals.Add(rental);
        }

        public string statement()
        {
            String result = "Rental record for " + getName() + "\n";
            foreach (var rental in rentals)
                result += "\t" + rental.getMovie().getTitle() + "\t" + rental.getCharge().ToString() + "\n";
            result += "Amount owed is " + getTotalCharge().ToString() + "\n";
            result += "You earned " + getTotalFrequentRenterPoints().ToString() + " frequent renter points";
            return result;
        }

        public String htmlStatement()
        {
            String result = "<h1>Rental record for <b>" + getName() + "</b></h1>\n";
            foreach (var rental in rentals)
                result += "<p>" + rental.getMovie().getTitle() + "\t" + rental.getCharge().ToString() + "</p>\n";
            result += "<p>Amount owed is <b>" + getTotalCharge().ToString() + "</b></p>\n";
            result += "<p>You earned <b>" + getTotalFrequentRenterPoints().ToString() + " frequent renter points</b></p>";
            return result;

        }

        private double getTotalCharge()
        {
            double total = 0;
            foreach (var rental in rentals)
                total += rental.getCharge();
            return total;
        }

        private int getTotalFrequentRenterPoints()
        {
            int total = 0;
            foreach (var rental in rentals)
                total += rental.getFrequentRenterPoints();
            return total;
        }

        //extra added functionality
        public void getCustomerTotalRentalPoints()
        {
            Console.WriteLine(getName() + " got " + getTotalFrequentRenterPoints() + " frequent points");
        }

        // extra added functonality for test case testing
        public int getCustomerRentals()
        {
            return rentals.Count;
        }
    }
}

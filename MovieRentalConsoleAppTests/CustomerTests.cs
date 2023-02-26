using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRentalConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalConsoleApp.Tests
{
    [TestClass()]
    public class CustomerTests
    { 
        [TestMethod()]
        public void addRentalTest()
        {
            Customer customer = new Customer("David");
            Movie regularPriceMovie = new Movie("Avatar", "REGULAR");
            Rental movieRental = new Rental(regularPriceMovie, 3);
            customer.addRental(movieRental);
            Assert.AreEqual(1, customer.getCustomerRentals());
        }

       
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalConsoleApp.Interceptor
{
    public class ContextObject
    {
        public ContextObject(Customer customer)
        {
            this.customer = customer;
        }

        private Customer customer;
        public string message { get; set; }
        public TimeSpan executionTime { get; set; }

        // display frequent points
        public void displaycustomerFrequentPoints()
        {
            customer.getCustomerTotalRentalPoints();
;       }

    }
}

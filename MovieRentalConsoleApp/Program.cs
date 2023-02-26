
using MovieRentalConsoleApp.Interceptor;
using System;

namespace MovieRentalConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create customer
            Customer customer = new Customer("Customer1");

            // create movies
            Movie regularMovie = new Movie("AVENGERS", "REGULAR");
            Movie childrenMovie = new Movie("MOANA", "CHILDREN");
            Movie newReleaseMovie = new Movie("GLASS ONION", "NEW_RELEASE");

            //create rental
            Rental regularMovieRental = new Rental(regularMovie, 3);
            Rental childrenMovieRental = new Rental(childrenMovie, 2);
            Rental newReleaseMovieRental = new Rental(newReleaseMovie, 2);

            // add the rented movies 
            customer.addRental(regularMovieRental);
            customer.addRental(childrenMovieRental);
            customer.addRental(newReleaseMovieRental);

            // define dispatcher
            var dispatcher = new Dispatcher();

            //register logging Interceptor with the dispatcher
            dispatcher.register(new LoggingInterceptor());

            //register Timer Interceptor with the dispatcher
            dispatcher.register(new TimerInterceptor());

            // define contextObject
            var context = new ContextObject(customer);
            context.message = "Displaying Customer Frequent Points";

            // dispatch the registered interceptors passing context as an argument.
            dispatcher.dispatch(context);

            // Other Function calls

            // display customer statement
            Console.WriteLine("Customer Statement: "+ customer.statement());
        }
    }
}

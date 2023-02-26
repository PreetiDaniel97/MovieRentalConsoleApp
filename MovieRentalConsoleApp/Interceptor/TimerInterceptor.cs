using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MovieRentalConsoleApp.Interceptor
{
    public class TimerInterceptor: IInterceptor
    {
        // records the exexcution time for the target request.
        public void intercept(ContextObject context)
        {
            // Start the timer
            var timer = new Stopwatch();
            timer.Start();
            Console.WriteLine("Timer started");

            // Execute the request
            context.displaycustomerFrequentPoints();

            // Stop the timer and record the elapsed time
            timer.Stop();

            //assigning the execution time to the context object which can be accessed by the framework.
            context.executionTime = timer.Elapsed;

            Console.WriteLine("Timer Ended");
            Console.WriteLine("Execution Time: " + timer.Elapsed.Duration());
        }
    }
}

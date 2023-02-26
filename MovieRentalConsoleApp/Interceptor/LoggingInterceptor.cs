using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalConsoleApp.Interceptor
{
    class LoggingInterceptor: IInterceptor
    {
        // logs the called method.
        public void intercept(ContextObject context)
        {
            Console.WriteLine("Log: "+context.message);
        }
    }
}

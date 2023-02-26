using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalConsoleApp.Interceptor
{
    public interface IInterceptor
    {
        void intercept(ContextObject context);
    }
}

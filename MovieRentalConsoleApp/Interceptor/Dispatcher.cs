using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalConsoleApp.Interceptor
{
    public class Dispatcher
    {
        private List<IInterceptor> interceptorList = new List<IInterceptor>();

        public void registerInterceptor(IInterceptor interceptor)
        {
            interceptorList.Add(interceptor);
        }

        public void dispatch(ContextObject context)
        {
            interceptorList.ForEach(x => x.intercept(context));
        }

        public void removeInterceptor(IInterceptor interceptor)
        {
            interceptorList.Remove(interceptor);
        }
    }
}

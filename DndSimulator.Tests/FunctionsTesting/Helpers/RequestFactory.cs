using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndSimulator.Tests.FunctionsTesting.Helpers
{
    internal class RequestFactory
    {
        public HttpRequest CreateHttpGetRequest()
        {
            var httpContext = new DefaultHttpContext();
            var request = httpContext.Request;

            return request;
        }
    }
}

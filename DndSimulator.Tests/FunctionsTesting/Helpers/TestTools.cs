using Microsoft.Extensions.Logging;

namespace DndSimulator.Tests.FunctionsTesting.Helpers
{
    internal class TestTools
    {
        internal readonly ILogger Log;
        internal readonly RequestFactory RequestFactory;

        public TestTools(ILogger log, RequestFactory requestFactory)
        {
            Log = log;
            RequestFactory = requestFactory;
        }
    }
}

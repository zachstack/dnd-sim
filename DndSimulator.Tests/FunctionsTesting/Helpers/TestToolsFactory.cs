using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndSimulator.Tests.FunctionsTesting.Helpers
{
    internal class TestToolsFactory
    {
        public static TestTools Create()
        {
            var log = CreateLogger();
            var requestFactory = new RequestFactory();

            var tools = new TestTools(log, requestFactory);

            return tools;
        }

        private static ILogger CreateLogger()
        {
            var logger = NullLoggerFactory.Instance.CreateLogger("Null Logger");

            return logger;
        }
    }
}

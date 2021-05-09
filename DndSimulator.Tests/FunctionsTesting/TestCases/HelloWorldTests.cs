using DndSimulator.Api.Functions;
using DndSimulator.Tests.FunctionsTesting.Helpers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Net;

namespace DndSimulator.Tests.FunctionsTesting.TestCases
{
    internal class HelloWorldTests
    {
        private readonly TestTools tools;
        private readonly HelloWorldFunction function;

        public HelloWorldTests()
        {
            tools = TestToolsFactory.Create();
            function = new HelloWorldFunction();
        }

        [Test]
        public void HelloWorld_BasicGet_Ok()
        {
            //Setup Test
            var request = tools.RequestFactory.CreateHttpGetRequest();

            //Execute Function
            var response  = (OkObjectResult)function.HelloWorld(request, tools.Log);

            //Assert
            Assert.AreEqual("Hello World!", response.Value);
        }
    }
}
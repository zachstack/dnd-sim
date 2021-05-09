using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DndSimulator.Api.Functions
{
    public class HelloWorldFunction
    {
        [FunctionName("HellowWorld")]
        public IActionResult HelloWorld(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "hello-world")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Hello World!");

            string message = "Hello World! We've got CD now!";

            return new OkObjectResult(message);
        }
    }
}
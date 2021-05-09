using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.OpenApi.Models;

namespace DndSimulator.Api.Functions
{
    public class HelloWorldFunction
    {
        [OpenApiOperation(operationId: "HelloWorld", Summary = "Gets the string \"Hello World!\"", Description = "Gets the string \"Hello World!\"", Visibility = OpenApiVisibilityType.Important)]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Summary = "The response", Description = "Returns the string \"Hello World!\"")]
        [FunctionName("HellowWorld")]
        public IActionResult HelloWorld(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "hello-world")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Hello World!");

            string message = "Hello World!";

            return new OkObjectResult(message);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApi
{
   
    public class HelloWorldContoller : Controller
    {
        private static ILogger<HelloWorldContoller> _logger;
        public HelloWorldContoller(ILogger<HelloWorldContoller> logger)
        {
            _logger = logger;
        }
        [HttpGet("/HelloWorld")]
        public IActionResult HelloWorld()
        {
            _logger.LogInformation("Logger Testing");
            return Ok("Hello World");
        }
    }
}

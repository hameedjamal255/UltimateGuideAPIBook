using LoggerService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltimateGuide_APi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ILoggerManager _logger1;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ILoggerManager logger1)
        {
            _logger = logger;
            _logger1 = logger1;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
        [HttpGet]
        public IEnumerable<string> Gets()
        {
            _logger1.LogInfo("Here is info message from our values controller.");
            _logger1.LogDebug("Here is debug message from our values controller.");
            _logger1.LogWarn("Here is warn message from our values controller.");
            _logger1.LogError("Here is an error message from our values controller.");
            return new string[] { "value1", "value2" };
        }

    }
}

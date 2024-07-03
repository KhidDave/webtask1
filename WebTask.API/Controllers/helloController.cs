using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class helloController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInteraction(string visitor_name)
        {
            var clientIP = "127.0.0.1";
            var location = "New York";
            var temperatureCelsius = 11;

            var response = new 
            {
                clientIP = clientIP,
                location = location,
                greetings = $"Hello, {visitor_name}! the temperature is {temperatureCelsius}ºC in {location}"
            };

            return Ok(response);
        }
    }
}

using Microsoft.AspNetCore.Mvc;


namespace ControllerAPI.Controllers
{
    /// <summary>
    /// Welcome and Health
    /// </summary>
    public class WelcomeController : Controller
    {
        /// <summary>
        /// Welcome to to Neon Response Controller API
        /// </summary>
        [HttpGet("/")]
        public IActionResult Welcome()
        {
            return Ok("Welcome to to Neon Response Controller API");
        }

        /// <summary>
        /// API is stand up???
        /// </summary>
        [HttpGet("/health")]
        public IActionResult Health()
        {
            return Ok("Up");
        }
    }
}

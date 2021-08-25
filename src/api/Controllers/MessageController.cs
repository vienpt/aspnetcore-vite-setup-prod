using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        [HttpGet]
        public IActionResult Get(string msg)
        {
            if (msg != null) {
                return Ok($"Hello {msg}");
            }
            return Ok("Hello message");
        }

        // api/message/custom?msg=test
        // [HttpGet("custom")]
        // public IActionResult GetByMsg(string msg)
        // {
        //     return Ok($"Hello {msg}");
        // }
    }
}
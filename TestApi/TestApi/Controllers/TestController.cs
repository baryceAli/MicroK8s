using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {

        public ActionResult<string> Get()
        {
            return Ok("Test");
        }
    }
}
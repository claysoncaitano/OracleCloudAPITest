using Microsoft.AspNetCore.Mvc;

namespace OracleCloudAPITest.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            return Ok("Deu Certo!");
        }
    }
}

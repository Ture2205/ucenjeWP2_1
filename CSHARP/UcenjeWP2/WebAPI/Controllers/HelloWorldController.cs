using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("controller")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]   
        public string PozdravljamSvijet()
        {
            return "Hello world";
        }
    }
}

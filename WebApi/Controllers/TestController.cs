using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]

    //Controller Routing
    [Route("api/[controller]")]  

    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "MonsterASP API is working!";
        }


        //Method Routing
        [HttpGet("check")]
        public string Check()
        {
            return "Checking API is working!";
        }
    }
}

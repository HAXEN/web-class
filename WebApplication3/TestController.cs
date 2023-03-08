using Microsoft.AspNetCore.Mvc;

namespace WebApplication3
{
    [Route("kalle")]
    public class TestController : ControllerBase
    {
        private string Something = "";

        public TestController(TestService testService)
        {
            var service = testService;
        }
        
        [HttpGet("{who}")]
        public IActionResult Get(string who)
        {
            if (string.IsNullOrEmpty(who))
                return Ok("Anyone");
            
            return Ok(who);
        }
    }
}
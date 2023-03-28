using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using GoogleLoginTest.Models;

namespace GoogleLoginTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public string Test()
        {
            TestObject testObject = new TestObject("test", 1);
            string json = JsonConvert.SerializeObject(testObject);
            return json;
        }
    }
}

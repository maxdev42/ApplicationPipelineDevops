using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace PipelineDevopsApi.Service.Controllers
{

    internal class MyJsonObject
    {
        public String Name { get; set; }
        public String Value { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class TestApiController : ControllerBase
    {

        private readonly ILogger<TestApiController> _logger;

        public TestApiController(ILogger<TestApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<object>> TestApi()
        {
            MyJsonObject myJsonObject = new MyJsonObject();

            myJsonObject.Name = "Test Api";
            myJsonObject.Value = "API ONLINE";

            var jsonResult = JsonConvert.SerializeObject(myJsonObject);

            try
            {
                return jsonResult;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebService.ModelsBuilder;

namespace WebService.Controllers
{
    [Route("api/weather")]
    [ApiController]
    public class WeatherCrudController : ControllerBase
    {
        private readonly ValuesHolder _holder;

        public WeatherCrudController(ValuesHolder holder)
        {
            _holder = holder;
        }

        [HttpPost("add")]
        public IActionResult Create(string value)
        {
            _holder.Add(value);
            return Ok();
        }

        [HttpGet("read")]
        public ActionResult<string> Read()
        {
            return Ok(_holder.Get());
        }
    }
}

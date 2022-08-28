using Microsoft.AspNetCore.Mvc;
using WebService.ModelsBuilder;

namespace WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]

    // ������
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherForecastHolder _holder;

        public WeatherForecastController(WeatherForecastHolder holder)
        {
            _holder = holder;
        }

        [HttpPost("add")]
        public IActionResult Add([FromQuery] DateTime date, [FromQuery] int temperatureC)
        {
            _holder.Add(date, temperatureC);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update([FromQuery] DateTime date, [FromQuery] int temperatureC)
        {
            return Ok(_holder.Update(date, temperatureC));
        }

        [HttpGet("get")]
        public IEnumerable<WeatherForecast> Get([FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
        {
            return _holder.Get(dateFrom, dateTo);
        }

        
    }
}
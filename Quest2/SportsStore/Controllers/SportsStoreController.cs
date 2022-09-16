using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SportsStoreController : ControllerBase
    {
        private readonly IHorizontalBar _HorizontalBar;
        private readonly IService _Service;

        //public WeatherForecastController(
        //    IWeatherForecastService weatherForecastService,
        //    IExampleService exampleService)
        //{
        //    _weatherForecastService = weatherForecastService;
        //    _exampleService = exampleService;
        //}

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return _weatherForecastService.GetForecasts();
        //}

        //[HttpGet("calculatePower")]
        //public double Power(double sourceNumber, int power)
        //{
        //    return Math.Pow(sourceNumber, power);
        //}

        //[HttpGet("example")]
        //public void Example()
        //{
        //    _exampleService.Print();
        //}
    }
}
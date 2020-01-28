using NUnit.Framework;
using drmovil.api.Controllers;

namespace drmovil.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            WeatherForecastController forecastController = new WeatherForecastController(null);

            Assert.IsNotNull(forecastController.Get());
        }
    }
}
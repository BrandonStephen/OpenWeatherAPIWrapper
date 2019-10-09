using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using WeatherAPITest.OpenWeatherAPI;
using Assert = NUnit.Framework.Assert;

namespace WeatherAPITest.Tests
{
    [TestFixture]
    public class MainTests
    {
        private WeatherApiService service = new WeatherApiService("London");

        [Test]
        public void TestLongitude()
        {
            // Checking Longitute
            Assert.AreEqual(-0.13, service.WeatherDTO.WeatherAPIRoots.Coord.Lon);
        }
        [Test]
        public void TestLatitude()
        {
            // Checking Latitude
            Assert.AreEqual(51.51, service.WeatherDTO.WeatherAPIRoots.Coord.Lat);
        }

        [Test]
        public void TestInstanceOfWeatherID()
        {
            // Check ID
            Assert.IsInstanceOf(typeof(int), service.WeatherDTO.WeatherAPIRoots.Weather[0].Id);
            
        }

        [Test]
        public void TestInstanceOfWeatherMain()
        {
            // Check Main Property
            Assert.IsInstanceOf(typeof(string), service.WeatherDTO.WeatherAPIRoots.Weather[0].Main);
        }

        [Test]
        public void TestInstanceOfWeatherDescription()
        {
            // Check Description
            Assert.IsInstanceOf(typeof(string), service.WeatherDTO.WeatherAPIRoots.Weather[0].Description);
           
        }

        [Test]
        public void TestInstanceOfWeatherIcon()
        {
            // Check Icon
            Assert.IsInstanceOf(typeof(string), service.WeatherDTO.WeatherAPIRoots.Weather[0].Icon);
        }

        [Test]
        public void TestBase()
        {
            Assert.AreEqual("stations", service.WeatherDTO.WeatherAPIRoots.Base);
        }

        [Test]
        public void TestInstanceOfMainTemp()
        {
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Main.Temp);
        }
        [Test]
        public void TestInstanceOfMainPressure()
        {
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Main.Pressure);
        }

        [Test]
        public void TestInstanceOfMainHumidity()
        {
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Main.Humidity);
        }

        [Test]
        public void TestInstanceOfMainTempMin()
        {
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Main.Temp_min);
        }

        [Test]
        public void TestInstanceOfMainTempMax()
        {
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Main.Temp_max);
        }

        [Test]
        public void TestVisibility()
        {
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Visibility);
        }

        [Test]
        public void TestWind()
        {
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Wind.Speed);
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Wind.Deg);
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Wind.Gust);
        }

        [Test]
        public void TestClouds()
        {
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Clouds.All);
        }

        [Test]
        public void TestDT()
        {
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Dt);
        }

        [Test]
        public void TestSys()
        {
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Sys.Type);
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Sys.Id);
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Sys.Message);
            Assert.IsInstanceOf(typeof(string), service.WeatherDTO.WeatherAPIRoots.Sys.Country);
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Sys.Sunrise);
            Assert.IsInstanceOf(typeof(double), service.WeatherDTO.WeatherAPIRoots.Sys.Sunset);
        }

        [Test]
        public void TestTimeZone()
        {
            Assert.AreEqual(3600, service.WeatherDTO.WeatherAPIRoots.Timezone);
        }

        [Test]
        public void TestStatus()
        {
            Assert.AreEqual(200, service.WeatherDTO.WeatherAPIRoots.Cod);
        }

        [Test]
        public void TestID()
        {
            Assert.IsInstanceOf(typeof(int), service.WeatherDTO.WeatherAPIRoots.Id);
        }

        [Test]
        public void TestName()
        {
            Assert.AreEqual("London", service.WeatherDTO.WeatherAPIRoots.Name);
        }


    }
}

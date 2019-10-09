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
        public void TestCoordinates()
        {
            
            Console.WriteLine(service.JSONObject);
            // Checking Longitute
            Assert.AreEqual(-0.13, service.WeatherDTO.WeatherAPIRoots.Coord.Lon);
            // Checking Latitude
            Assert.AreEqual(51.51, service.WeatherDTO.WeatherAPIRoots.Coord.Lat);
        }

        [Test]
        public void TestWeatherInfo()
        {
            // Check ID
            Assert.IsInstanceOf(typeof(int), service.WeatherDTO.WeatherAPIRoots.Weather[0].Id);
            // Check Main Property
            Assert.IsInstanceOf(typeof(string), service.WeatherDTO.WeatherAPIRoots.Weather[0].Main);
            // Check Description
            Assert.IsInstanceOf(typeof(string), service.WeatherDTO.WeatherAPIRoots.Weather[0].Description);
            // Check Icon
            Assert.IsInstanceOf(typeof(string), service.WeatherDTO.WeatherAPIRoots.Weather[0].Icon);
        }

        [Test]
        public void TestBase()
        {
            Assert.AreEqual("stations", service.WeatherDTO.WeatherAPIRoots.Base);
        }

        

    }
}

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
        private WeatherApiService WeatherAPIWrapper = new WeatherApiService("London");
        [Test]
        public void TestCoordinates()
        {
            // Checking Longitute
            Assert.AreEqual(-0.13, WeatherAPIWrapper.WeatherDTO.WeatherAPIRoots.Coords.Ion);
            // Checking Latitude
            Assert.AreEqual(51.51, WeatherAPIWrapper.WeatherDTO.WeatherAPIRoots.Coords.Lat);
        }
    }
}

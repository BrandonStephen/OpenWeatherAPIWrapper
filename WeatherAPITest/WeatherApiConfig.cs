using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WeatherAPITest
{
    public static class WeatherApiConfig
    {
        public static readonly String BaseUrl = ConfigurationManager.AppSettings["baseURL"];
        public static readonly String ApiKey = ConfigurationManager.AppSettings["apiKey"];
        public static readonly String CityMod = ConfigurationManager.AppSettings["cityMod"];
    }
}

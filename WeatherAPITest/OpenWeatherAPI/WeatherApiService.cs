using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPITest.OpenWeatherAPI.Data_Handling;
using WeatherAPITest.OpenWeatherAPI.HTTP_Manager;

namespace WeatherAPITest.OpenWeatherAPI
{
    class WeatherApiService
    {
        // OpenWeatherAPI DTO
        public WeatherDTO WeatherDTO = new WeatherDTO();

        // OpenWeather HTTP Call Manager
        public WeatherCallManager WeatherCallManager = new WeatherCallManager();

        // JSON Object
        public JObject JSONObject;

        public WeatherApiService(string city)
        {
            WeatherDTO.Deserialization(WeatherCallManager.GetWeatherInfoByCityName(city));
            JSONObject = JObject.Parse(WeatherCallManager.GetWeatherInfoByCityName(city));
        }
    }
}

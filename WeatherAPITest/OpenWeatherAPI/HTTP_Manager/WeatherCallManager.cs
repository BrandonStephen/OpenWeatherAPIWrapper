using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace WeatherAPITest.OpenWeatherAPI.HTTP_Manager
{
    class WeatherCallManager
    {
        readonly IRestClient client;

        public WeatherCallManager()
        {
            client = new RestClient(WeatherApiConfig.BaseUrl);
        }

        public string GetWeatherInfoByCityName(string CityName)
        {
            var request = new RestRequest("/data/2.5/weather" + WeatherApiConfig.CityMod + CityName
                + "&" + WeatherApiConfig.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}

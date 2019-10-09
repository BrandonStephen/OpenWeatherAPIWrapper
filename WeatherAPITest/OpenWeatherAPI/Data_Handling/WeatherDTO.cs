using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAPITest.OpenWeatherAPI.Data_Handling
{
    class WeatherDTO
    {
        public WeatherAPIRoots WeatherAPIRoots { get; set; }

        public void Deserialization(String WeatherAPI)
        {
            WeatherAPIRoots = JsonConvert.DeserializeObject<WeatherAPIRoots>(WeatherAPI);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPITest.OpenWeatherAPI.Data_Handling
{
    class WeatherAPIRoots
    {
        public Coord Coord { get; set; }
        public List<Weather> Weather { get; set; }
        public string @Base { get; set; }
        public Main Main { get; set; }
        public double @Visibility { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public double @Dt { get; set; }
        public Sys Sys { get; set; }
        public int @Timezone { get; set; }
        public int @Id { get; set; }
        public string @Name { get; set; }
        public int @Cod { get; set; }
    }

    class Coord
    {
        private double lon;
        private double lat;

        public double Lon { get; set; }
        public double Lat { get; set; }
    }

    class Weather
    {
        private int id;
        private string main;
        private string description;
        private string icon;

        public int Id { get => id; set => id = value; }
        public string Main { get => main; set => main = value; }
        public string Description { get => description; set => description = value; }
        public string Icon { get => icon; set => icon = value; }
    }
        class Main
    {
        private double temp;
        private double pressure;
        private double humidity;
        private double temp_min;
        private double temp_max;

        public double Temp { get => temp; set => temp = value; }
        public double Pressure { get => pressure; set => pressure = value; }
        public double Humidity { get => humidity; set => humidity = value; }
        public double Temp_min { get => temp_min; set => temp_min = value; }
        public double Temp_max { get => temp_max; set => temp_max = value; }
    }

    class Wind
    {
        private double speed;
        private double deg;
        private double gust;

        public double Speed { get; set; }
        public double Deg { get; set; }
        public double Gust { get => gust; set => gust = value; }
    }

    class Clouds
    {
        private double all;

        public double All { get; set; }
    }

    class Sys
    {
        private double type;
        private double id;
        private double message;
        private string country;
        private double sunrise;
        private double sunset;

        public double Type { get => type; set => type = value; }
        public double Id { get => id; set => id = value; }
        public double Message { get => message; set => message = value; }
        public string Country { get => country; set => country = value; }
        public double Sunrise { get => sunrise; set => sunrise = value; }
        public double Sunset { get => sunset; set => sunset = value; }
    }
}

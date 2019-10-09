using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPITest.OpenWeatherAPI.Data_Handling
{
    class WeatherAPIRoots
    {
        public Coords coords { get; set; }
        public Weather weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public string @visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public string @dt { get; set; }
        public Sys sys { get; set; }
        public string @timezone { get; set; }
        public string @id { get; set; }
        public string @name { get; set; }
        public string @cod { get; set; }
    }

    class Coords
    {
        private string ion;
        private string lat;

        public string Ion { get => ion; set => ion = value; }
        public string Lat { get => lat; set => lat = value; }
    }

    class Weather
    {
        private string id;
        private string main;
        private string description;
        private string icon;

        public string Id { get => id; set => id = value; }
        public string Main { get => main; set => main = value; }
        public string Description { get => description; set => description = value; }
        public string Icon { get => icon; set => icon = value; }
    }

    class Main
    {
        private string temp;
        private string pressure;
        private string humidity;
        private string temp_min;
        private string temp_max;

        public string Temp { get => temp; set => temp = value; }
        public string Pressure { get => pressure; set => pressure = value; }
        public string Humidity { get => humidity; set => humidity = value; }
        public string Temp_min { get => temp_min; set => temp_min = value; }
        public string Temp_max { get => temp_max; set => temp_max = value; }
    }

    class Wind
    {
        private string speed;
        private string deg;

        public string Speed { get => speed; set => speed = value; }
        public string Deg { get => deg; set => deg = value; }
    }

    class Clouds
    {
        private string all;

        public string All { get => all; set => all = value; }
    }

    class Sys
    {
        private string type;
        private string id;
        private string message;
        private string country;
        private string sunrise;
        private string sunset;

        public string Type { get => type; set => type = value; }
        public string Id { get => id; set => id = value; }
        public string Message { get => message; set => message = value; }
        public string Country { get => country; set => country = value; }
        public string Sunrise { get => sunrise; set => sunrise = value; }
        public string Sunset { get => sunset; set => sunset = value; }
    }
}

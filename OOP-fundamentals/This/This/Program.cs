using System;

namespace This
{
    class Weather
    {
        public int MaxTemperature { get; set; }
        public int MinTemperature { get; set; }

        public Weather(RioDeJaneiroWeather weather)
        {
            this.MaxTemperature = weather.MaxTemperature;
            this.MinTemperature = weather.MinTemperature;

            Console.WriteLine($"Max/Min temperature:{this.MaxTemperature}/{this.MinTemperature}");
        }
    }

    class RioDeJaneiroWeather
    {
        public int MaxTemperature { get; set; }
        public int MinTemperature { get; set; }

        public RioDeJaneiroWeather(int maxTemperature, int minTemperature)
        {
            MaxTemperature = maxTemperature;
            MinTemperature = minTemperature;

            Weather weather = new Weather(this);
            Console.WriteLine($"Max/Min temperature:{weather.MaxTemperature}/{weather.MinTemperature}");
        }
    }

    class WeatherFinal
    {
        static void Main(string[] args)
        {

        }
    }
}

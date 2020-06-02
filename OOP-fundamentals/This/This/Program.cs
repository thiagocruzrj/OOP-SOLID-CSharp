using System;

namespace This
{
    class Weather
    {
        public int MaxTemperature { get; set; }
        public int MinTemperature { get; set; }

        public Weather(int MaxTemperature, int MinTemperature)
        {
            this.MaxTemperature = MaxTemperature;
            this.MinTemperature = MinTemperature;
        }
    }
}

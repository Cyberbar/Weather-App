using System.Collections.Generic;

namespace Weather_App
{
    internal class WeatherInfo
    {
        // Class to hold coordinate information
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        // Class to hold weather condition information
        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        // Class to hold main weather data
        public class main
        {
            public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
        }

        // Class to hold wind data
        public class wind
        {
            public double speed { get; set; }
        }

        // Class to hold system data like sunrise and sunset
        public class sys
        {
            public long sunrise { get; set; }
            public long sunset { get; set; }
        }

        // Root class to hold the overall weather data structure
        public class root
        {
            public coord coord { get; set; }
            public List<weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
        }
    }
}

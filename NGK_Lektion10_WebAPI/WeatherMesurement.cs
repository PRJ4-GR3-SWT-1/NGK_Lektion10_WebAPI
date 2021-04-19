using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGK_Lektion10_WebAPI
{
    public class WeatherMesurement
    {
        public DateTime Date { get; set; }
        public double Temperature { get; set; }
        public int Humidity { get; set; }
        public double AirPressure { get; set; }
    }
}

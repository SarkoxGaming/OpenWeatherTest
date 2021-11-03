using System;

namespace WeatherApp.Models
{
    public class WindDataModel
    {
        public DateTime DateTime { get; set; }
        public double MetrePerSec { get; set; }
        public double Direction { get; set; }



        public override string ToString()
        {
            return string.Format("Date: {0}\nVitesse: {1}\nDirection: {2}", DateTime,MetrePerSec,Direction);
        }

    }
}

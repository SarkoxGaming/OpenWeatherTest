using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    class OpenWeatherService : IWindDataService
    {
        public WindDataModel LastWindData;
        private OpenWeatherProcessor owp;
        public OpenWeatherService(string apiKey)
        {
            owp = OpenWeatherProcessor.Instance;
            owp.ApiKey = apiKey;
        }

        public async Task<WindDataModel> GetDataAsync()
        {
            var data = await owp.GetCurrentWeatherAsync();
            var result = new WindDataModel
            {
                DateTime = DateTime.UnixEpoch.AddSeconds(data.DateTime),
                Direction = data.Wind.Deg
            };
            LastWindData = result;
            return LastWindData;
        }
    }
}

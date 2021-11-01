using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public static class AppConfiguration
    {
        private static IConfiguration configuration;

        public static string GetValue(string v)
        {
            if (configuration == null) initConfig();
            return configuration[v];
        }

        private static void initConfig()
        {
            var builder = new ConfigurationBuilder();

            builder.AddJsonFile("appsettings.json",
                optional: true,
                reloadOnChange: true);

            builder.AddUserSecrets<MainWindow>();

            configuration = builder.Build();
        }
    }
}

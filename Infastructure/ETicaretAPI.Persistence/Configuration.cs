using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {

                //var AppName = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["APP_Name"];

                // Eski yöntem.

                //ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicatetAPI.API"));
                //configurationManager.AddJsonFile("appsettings.json");
                //return configurationManager.GetConnectionString("PostgreSQL");

                ConfigurationBuilder builder = new ConfigurationBuilder();
                builder.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicaretAPI.API"));
                builder.AddJsonFile("appsettings.json");

                IConfigurationRoot configuration = builder.Build();

                return configuration.GetConnectionString("PostgreSQL");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace wheatherapi
{
    public  static class ApiServicesExtensions
    {
        public static void AddWeatherService(this IServiceCollection services)
        {
            services.AddHttpClient<IWheatherService, WeatherService>(c =>
            {
                c.BaseAddress = new Uri("http://api.weatherapi.com/v1/current.json");
            });
        }
    }
}

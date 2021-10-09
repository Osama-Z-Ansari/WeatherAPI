using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace wheatherapi
{
    public class WeatherService : IWheatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient) => _httpClient = httpClient;

        public async Task<string> Get(string cityName)
        {
            var apiKey = "9e684a78ef3e41b2bcd60007210810";

            string apiUrl = $"?key={apiKey}&q={cityName}";
            var response = await _httpClient.GetAsync(apiUrl);
            return await response.Content.ReadAsStringAsync();
        }   
    }
}

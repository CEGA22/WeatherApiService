using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.Helper
{
    public class WebMethods
    {
        static HttpClient _httpClient;
        
        public static async Task<string> MakeGetRequest(string url)
        {
            try
            {
                _httpClient = new HttpClient
                {
                    BaseAddress = new Uri(url)
                };
               var results = await _httpClient.GetStringAsync(url);
               return results; 
            }
            catch
            {
                return "error";
            }
        }
    }
}

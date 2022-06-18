using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.Constants
{
    public static class EndpointConstants
    {
        public const string ApiKey = "3ef872d84a1d2965faed8af27c3ed830";
        public const string SearchKey = "London";

        public const string QueryString = $"?q={SearchKey}&appid={ApiKey}";

        public const string QueryStringXml = $"?q={SearchKey}&mode=xml&appid={ApiKey}";

        public const string BaseUrl = "https://api.openweathermap.org/data/2.5/weather";

        public const string GetWeather = EndpointConstants.BaseUrl + EndpointConstants.QueryString;

        public const string GetWeatherXml = EndpointConstants.BaseUrl + EndpointConstants.QueryStringXml;        
    }
}

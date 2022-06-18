﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WeatherAPI.Constants;
using WeatherAPI.Helper;
using WeatherAPI.Models;

namespace WeatherAPI.Services
{
    public class WeatherService
    {       
        public async Task<CountryWeather.Root?>GetCountryWeather()
        {
            try
            {
                var content = await WebMethods.MakeGetRequest(EndpointConstants.GetWeather);
                return JsonConvert.DeserializeObject<CountryWeather.Root?>(content);
            }
            catch (Exception e)
            {
                var x = e.Message;
                return null;
            }
        }

        public async Task<Current?> GetCountryWeatherXml()
        {
            try
            {
                var content = await WebMethods.MakeGetRequest(EndpointConstants.GetWeatherXml);               
                XmlSerializer serializer = new (typeof(Current));
                using (StringReader reader = new (content))
                {
                    return serializer.Deserialize(reader) as Current;                   
                }
            }
            catch (Exception e)
            {
                var x = e.Message;
                return null;
            }
        }
    }
}

// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using WeatherAPI.Helper;
using WeatherAPI.Models;
using WeatherAPI.Services;
using WeatherAPI;

WeatherService weatherService = new WeatherService();
var country = await weatherService.GetCountryWeather();
var countryXml = await weatherService.GetCountryWeatherXml();
Console.WriteLine("JSON response");
Console.WriteLine($"Country:{country.name}");
Console.WriteLine($"Weather:{country.weather[0].description}");
Console.WriteLine($"Temperature:{country.main.temp}");
Console.WriteLine($"Humidity:{country.main.humidity}");
Console.WriteLine("===================================");
Console.WriteLine("XML response");
Console.WriteLine($"Country:{countryXml.City.Name}");
Console.WriteLine($"Weather:{countryXml.Clouds.Name}");
Console.WriteLine($"Temperature:{countryXml.Temperature.Value}");
Console.WriteLine($"Humidity:{countryXml.Humidity.Value}");
Console.ReadLine();



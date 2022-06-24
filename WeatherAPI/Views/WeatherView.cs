// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using WeatherAPI.Helper;
using WeatherAPI.Models;
using WeatherAPI.Services;
using WeatherAPI;

WeatherService weatherService = new WeatherService();
var country = await weatherService.GetCountryWeather();
Console.WriteLine("JSON response");

if (country == null)
{
    Console.WriteLine("There was error processing request");
}
else
{
    Console.WriteLine($"Country:{country.name}");
    Console.WriteLine($"Weather:{country.weather[0].description}");
    Console.WriteLine($"Temperature:{country.main.temp}");
    Console.WriteLine($"Humidity:{country.main.humidity}");
}

Console.WriteLine("===================================");

var countryXml = await weatherService.GetCountryWeatherXml();
Console.WriteLine("XML response");

if (countryXml == null)
{
    Console.WriteLine("There was error processing request");
}

else
{
    
    Console.WriteLine($"Country:{countryXml.City.Name}");
    Console.WriteLine($"Weather:{countryXml.Clouds.Name}");
    Console.WriteLine($"Temperature:{countryXml.Temperature.Value}");
    Console.WriteLine($"Humidity:{countryXml.Humidity.Value}");   
}
Console.ReadLine();






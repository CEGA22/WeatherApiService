using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.Models
{
    public partial class CountryWeather
    {                  
            public List<Weather>? weather { get; set; }              
            public Main? main { get; set; }                
            public string? name { get; set; }                                 
    }
}

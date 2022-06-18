using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WeatherAPI.Models
{
	public class City
	{
		[XmlAttribute(AttributeName = "name")]
		public string? Name { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WeatherAPI.Models
{
	[XmlRoot(ElementName = "temperature")]
	public class Temperature
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WeatherAPI.Models;

[XmlRoot(ElementName = "current")]
public partial class Current
{
	[XmlElement(ElementName = "city")]
	public City? City { get; set; }

	[XmlElement(ElementName = "clouds")]
	public Clouds? Clouds { get; set; }

	[XmlElement(ElementName = "temperature")]
	public Temperature? Temperature { get; set; }

	[XmlElement(ElementName = "humidity")]
	public Humidity? Humidity { get; set; }	
}




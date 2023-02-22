using System.Xml.Linq;

String Key = "4f8b9dc5513692726d40447a8db1859e";
String Connection = "https://api.openweathermap.org/data/2.5/weather?q=Istanbul&mode=xml&lang=tr&units=metric&appid=" + Key;
XDocument Weather = XDocument.Load(Connection);
var temp = Weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
Console.WriteLine("Sıcaklık" + temp);
Console.ReadLine();

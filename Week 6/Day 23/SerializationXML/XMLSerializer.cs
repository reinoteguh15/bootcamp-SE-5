namespace SerializationXML;

using System.Xml.Serialization;

public static class XMLSerializer
{
	public static void SerializeObject<T> (T? instance, string filePath)
	{		
		var serializer = new XmlSerializer (instance!.GetType());
		using (StreamWriter sw = new StreamWriter($"./{filePath}"))
		{
			serializer.Serialize(sw, instance);
		}
	}
}

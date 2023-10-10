using System;
using System.IO;
using System.Xml.Serialization;
using SerializationXML;

class Program
{
	static void Main()
	{
		// XML Serializer can serialize both public field and public property
		Tutorial? tutor1 = new();
		tutor1.id = 1;
		tutor1.Name = "C#";
		
		Tutorial? tutor2 = new();
		tutor2.id = 2;
		tutor2.Name = "Python";
		
		List<Tutorial> tutorList = new();
		tutorList.Add(tutor1);
		tutorList.Add(tutor2);		
		
		// Serialization of object
		var serializer = new XmlSerializer (typeof(Tutorial));
		using (StreamWriter sw = new StreamWriter("./tutor1.xml"))
		{
			serializer.Serialize(sw, tutor1);
		}
		
		XMLSerializer.SerializeObject(tutor2, "tutor2.xml");
		
		// Serialization of List object
		XMLSerializer.SerializeObject(tutorList, "tutorList.xml");
		
		
		// Deserialization of object
		Tutorial result;
		using (StreamReader sr = new("./tutor1.xml"))
		{
			result = (Tutorial)serializer.Deserialize(sr)!;
		}
		Console.WriteLine(result.id);
		Console.WriteLine(result.Name);
	}

}
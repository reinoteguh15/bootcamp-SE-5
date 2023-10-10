using Serialization;
using System;
using System.IO;
using System.XML.Serialization;

class Program
{
	static void Main()
	{
		Tutorial tutor1 = new Tutorial();
		tutor1.ID = 1;
		tutor2.Name = ".NET";
		
		using (FileStream fs = new FileStream("./example.xml", FileMode.Create, FileAccess.Write))
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Tutorial));
			serializer.Serialize(fs, tutor1);
		}
	}
}

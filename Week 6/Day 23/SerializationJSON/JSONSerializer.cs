namespace SerializationJSON;

using System.Text.Json;

public static class JSONSerializer
{
	public static void SerializeObject<T> (T? instance, string filePath)
	{		
		string serializer = JsonSerializer.Serialize(instance);
		using (StreamWriter sw = new StreamWriter($"./{filePath}"))
		{
			sw.Write(serializer);
		}
	}
}

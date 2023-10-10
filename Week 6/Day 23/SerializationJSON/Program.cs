using System;
using System.IO;
using System.Text.Json;
using SerializationJSON;

class Program
{
	static void Main()
	{
		// JSON Serializer can serialize only public property
		Car car1 = new Car();
		car1.Brand = "Toyota";
		car1.Year = 2015;
		
		Car car2 = new Car();
		car2.Brand = "Volkswagen";
		car2.Year = 2018;
		
		List<Car> carList = new();
		carList.Add(car1);
		carList.Add(car2);
		
		// Serialize JSON of a class Car
		string serializer = JsonSerializer.Serialize(car1);
		using (StreamWriter sw = new StreamWriter("./car1.json"))
		{
			sw.Write(serializer);
		}
		
		JSONSerializer.SerializeObject(car2, "car2.json");
		
		// Serialize JSON of List of class Car
		JSONSerializer.SerializeObject(carList, "carList.json");
		
		// Deserialize JSON
		Car result;
		using (StreamReader sr = new StreamReader("./car1.json"))
		{
			string? resultJson = sr.ReadToEnd();
			result = JsonSerializer.Deserialize<Car>(resultJson);
		}
		Console.WriteLine(result.Brand);
		Console.WriteLine(result.Year);
	}
}

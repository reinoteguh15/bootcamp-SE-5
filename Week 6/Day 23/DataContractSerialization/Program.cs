using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using DataContractSerialization;

class Program
{
	static void Main()
	{
		Car car = new Car();
		car.year = 2016;
		car.Brand = "Mitsubishi";
		
		// Serialize using DataContract
		var serializer = new DataContractJsonSerializer(typeof(Car));
		using (FileStream fs = new FileStream("./car.json", FileMode.Create))
		{
			serializer.WriteObject(fs, car);
		}
		
		Car result;
		using (FileStream fs = new FileStream("./car.json", FileMode.Open))
		{
			result = (Car)serializer.ReadObject(fs);
		}
		Console.WriteLine(result!.year);
		Console.WriteLine(result.Brand);
	} 
}
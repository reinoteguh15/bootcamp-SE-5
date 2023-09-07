using ValueandReference;
class Program
{
	static void Main()
	{
		// Value type
		int a = 3;
		int b = a;
		b = 2;
		
		Console.WriteLine($"a: {a}");
		Console.WriteLine($"b: {b}");
		
		// Reference type
		Car car1 = new Car(3000);
		Car car2 = car1;
		car2.price = 2000;
		
		Console.WriteLine($"Price of car a: {car1.price}");
		Console.WriteLine($"Price of car b: {car2.price}");
		
		// Reference type - special case: String (Immutable)
		string c = "Hello";
		string d = c;
		d = "World";
		Console.WriteLine($"String c: {c}");
		Console.WriteLine($"String d: {d}");
	}
}
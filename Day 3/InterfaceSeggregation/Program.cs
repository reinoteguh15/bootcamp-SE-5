using InterfaceSeggregation;

class Program
{
	static void Main()
	{
		KarambolPlayer karambol = new();
		Console.WriteLine(karambol.GetName());
		Console.WriteLine(karambol.GetID());
		
		ValorantPlayer valo = new();
		Console.WriteLine(valo.GetName());
		Console.WriteLine(valo.GetID());
		Console.WriteLine(valo.GetUsername());
		Console.WriteLine(valo.GetServer());
	}
}

using EnumPlanet;
class Program
{
	static void Main()
	{
		// Get array of enums
		Planet[] planets = (Planet[])Enum.GetValues(typeof(Planet));
		foreach(var planet in planets)
		{
			Console.WriteLine($"Planet: {planet.ToString()}");
		}
		
		// Get array of strings
		string[] planetsInString = Enum.GetNames(typeof(Planet));
		foreach(var p in planetsInString)
		{
			Console.WriteLine(p);
		}
		
		EnumPrinter(Planet.Mercury);
	}
	
	static void EnumPrinter(Planet p)
	{
		Console.WriteLine(p.ToString());
	}
}

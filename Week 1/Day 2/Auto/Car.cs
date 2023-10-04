namespace Auto;

public class Car
{
	public Engine engine;
	public string? brand;
	public int year;
	
	// Constructors
	public Car(Engine engine, string brand, int year)
	{
		this.engine = engine;
		this.brand = brand;
		this.year = year;
	}
	
	//Methods
	public void EngineCheck()
	{
		Console.WriteLine("Engine Check started...");
		Console.WriteLine("Engine: " + engine.brand);
		Console.WriteLine("Cyllinder: " + engine.cylinder);
		Console.WriteLine("Capacity: " + engine.capacity + " cc");
	}
	
	public void BrandCheck()
	{
		Console.WriteLine("Brand Check started...");
		Console.WriteLine("Brand: " + brand);
	}
	
	public void YearCheck()
	{
		Console.WriteLine("Year Check started...");
		Console.WriteLine("Year: " + year);
	}
}

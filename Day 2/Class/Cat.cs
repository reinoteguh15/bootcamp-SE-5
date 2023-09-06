namespace HewanDarat;

public class Cat
{
	public string? name;
	public int age;
	public string? color;
	
	// Constructor
	public Cat()
	{
		
	}
	
	public Cat(string name, int age, string color)
	{
		this.name = name;
		this.age = age;
		this.color = color;
	}
	
	// Overload
	public void Meow()
	{
		Console.WriteLine("Meow");
	}
	
	public void Meow(int times)
	{
		Console.WriteLine("Meow " + times + " times");
	}
	
	public void Meow(string loudness)
	{
		Console.WriteLine("Meow " + loudness);
	}
	
}

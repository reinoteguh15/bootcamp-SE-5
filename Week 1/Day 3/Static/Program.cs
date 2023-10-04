using Static;

class Program
{
	static void Main()
	{
		Cat cat1 = new Cat("Cibi", 20);
		Cat cat2 = new Cat("Burhan", 22);
		
		Console.WriteLine(cat1.GetName());
		Console.WriteLine(cat1.GetAge());
		Console.WriteLine(cat2.GetName());
		Console.WriteLine(cat2.GetAge());	
	}
}

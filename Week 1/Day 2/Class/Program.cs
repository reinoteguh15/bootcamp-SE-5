using HewanDarat;

class Program
{
	static void Main()
	{
		Cat cibi = new Cat("cibi", 1, "yellow");
		Cat burhan = new Cat("burhan", 2, "brown");
		Cat sushi = new Cat();
		
		Console.WriteLine(cibi.name);
		cibi.Meow();
		
		Console.WriteLine(burhan.name);
		burhan.Meow(3);
		
		Console.WriteLine(sushi.name);
		sushi.Meow("loudly");
	}
}
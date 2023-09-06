using HewanDarat;

class Program
{
	static void Main()
	{
		Cat chibi = new Cat();
		chibi.name = "Chibi";
		Console.WriteLine(chibi.name);
		chibi.Meow();
		
		Cat burhan = new Cat();
		burhan.name = "Burhan";
		Console.WriteLine(burhan.name);
		burhan.Jump();
		
		Dog bentley = new Dog();
		bentley.name = "Bentley";
		Console.WriteLine(bentley.name);
		bentley.Eat();
	}
}

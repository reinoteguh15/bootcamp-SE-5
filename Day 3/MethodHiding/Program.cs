using MethodHiding;

class Program
{
	static void Main()
	{
		Cat cat =new Cat();
		Animal animal = cat;
		
		Console.WriteLine(animal.name);
		cat.name = "hiro";
		Console.WriteLine(cat.name);
		
		// Overriding, so that the parent class will print the same output as the child class
		cat.MakeSound();
		animal.MakeSound();
		
		// Method hiding, so it will print its output
		cat.Eat();
		animal.Eat();
	}
}
namespace AbstractClass;

public class Bird : Animal, IAnimal
{
	public Bird(string name, int age)
	{
		this.name = name;
		this.age = age;	
		Console.WriteLine($"Hi, I'm a Bird called {name}, I'm {age} years old");
	}
	
	// Inherit from Abstract Class
	public override void Eat()
	{
		Console.WriteLine($"{name} eats seed...");
	}

	public override void MakeSound()
	{
		Console.WriteLine($"{name} is chirping...");
	}
	
	// Implementing Interface
	public void Move()
	{
		Console.WriteLine($"{name} is flying...");
	}
}

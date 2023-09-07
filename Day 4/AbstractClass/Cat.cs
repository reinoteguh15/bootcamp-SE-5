namespace AbstractClass;

public class Cat : Animal, IAnimal
{
	public Cat(string name, int age)
	{
		this.name = name;
		this.age = age;
		Console.WriteLine($"Hi, I'm a Cat called {name}, I'm {age} years old");
	}
	
	// Inherit from abstract class
	public override void Eat()
	{
		Console.WriteLine($"{name} eats fish...");
	}

	public override void MakeSound()
	{
		Console.WriteLine($"{name} is meowing...");
	}
	
	// Implement the interface
	public void Move()
	{
		Console.WriteLine($"{name} is walking...");
	}
	
}

namespace AbstractClass;

public class Dog : Animal, IAnimal
{
	public Dog(string name, int age)
	{
		this.name = name;
		this.age = age;
		Console.WriteLine($"Hi, I'm a Dog called {name}, I'm {age} years old");
	}

	// Inherit from abstract class
	public override void Eat()
	{
		Console.WriteLine($"{name} eats bone...");
	}

	public override void MakeSound()
	{
		Console.WriteLine($"{name} is barking...");
	}
	
	// Implement the interface
	public void Move()
	{
		Console.WriteLine($"{name} is running...");
	}
	
}

namespace animalInherit;

class Animal
{
	public string? name;
	public int age;
	
	public Animal(string name)
	{
		Console.WriteLine("Animal " + name + " is created");
	}
	public void Eat()
	{
		Console.WriteLine("Eat...");
	}
}

class Cat : Animal
{
	public Cat(string name) : base(name)
	{
		Console.WriteLine("Cat " + name + " is created");
		this.name = name;
	}
	
	public void Meow()
	{
		Console.WriteLine("Meow...");
	}
	
	public void Jump()
	{
		Console.WriteLine("Jump...");
	}
}

class Fish : Animal
{
	public Fish() : base("fish")
	{
		Console.WriteLine("Fish is created...");
	}
	
	public void Swim()
	{
		Console.WriteLine("Swim...");
	}
}
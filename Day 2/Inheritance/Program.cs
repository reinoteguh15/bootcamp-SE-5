using animalInherit;

class Program
{
	static void Main()
	{
		Cat cat = new Cat("hiro");
		Console.WriteLine(cat.name);
		cat.Eat();
		cat.Meow();
		cat.Jump();
		
		Fish fish = new Fish();
		Console.WriteLine(fish.name);
		fish.Eat();
		fish.Swim();
		
		Animal animal = new Animal("cat");
		Console.WriteLine(animal.name);
		animal.Eat();
	}
}
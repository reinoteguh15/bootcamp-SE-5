using AbstractClass;

class Program
{
	static void Main()
	{
		Cat cat = new Cat("Martin", 2);
		cat.Breathe();
		cat.Eat();
		cat.MakeSound();
		cat.Move();
		
		Console.WriteLine();
		
		Dog dog = new Dog("Bentley", 5);
		dog.Breathe();
		dog.Eat();
		dog.MakeSound();
		dog.Move();
		
		Console.WriteLine();
		Bird bird = new Bird("Burung", 1);
		bird.Breathe();
		bird.Eat();
		bird.MakeSound();
		bird.Move();
	}
}

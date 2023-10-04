using VirtualOverride;
class Program
{
	static void Main()
	{
		Animal animal = new Animal();
		animal.MakeSound();
		
		// Cat is overriding, so that the MakeSound() method prints different string
		Cat cat = new Cat(); 
		cat.MakeSound();
		
		Ant ant = new Ant();
		ant.MakeSound();
	}
}
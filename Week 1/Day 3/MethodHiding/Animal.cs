namespace MethodHiding;

public class Animal
{
	public string name = "animal";
	public int age = 2;
	
	public virtual void MakeSound()
	{
		Console.WriteLine("Animal make sound...");
	}
	
	public void Eat()
	{
		Console.WriteLine("Animal eats...");
	}
}

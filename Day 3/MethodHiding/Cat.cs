namespace MethodHiding;

public class Cat : Animal
{
	public string race = "persian";
	public override void MakeSound()
	{
		Console.WriteLine("Meow...");
	}
	public void Jump()
	{
		Console.WriteLine("Cat jumps...");
	}
	// Method hiding using 'new' keyword
	public new void Eat()	
	{
		Console.WriteLine("Cat eats...");
	}
	
}

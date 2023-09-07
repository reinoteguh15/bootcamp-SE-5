namespace AbstractClass;

public abstract class Animal
{
	public string? name; //protected or private
	public int? age;
	
	// Non-abstract method
	public void Breathe()
	{
		Console.WriteLine("I'm breathing...Inhale...Exhale...");
	}
	
	public abstract void Eat(); 
	public abstract void MakeSound();
}

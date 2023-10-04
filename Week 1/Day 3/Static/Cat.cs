namespace Static;

// Static is a non-instance or non-object
// Static method can access static variable or another static methods
class Cat
{
	public static string? name;
	public int age;
	
	public Cat(string names, int age)
	{
		name = names;
		this.age = age;
	}
	
	public static void Eat()	// Static --> Static
	{
		Console.WriteLine("Eat");
		Console.WriteLine(name);
	}
	
	public string? GetName()		// Instance --> Static
	{
		return name;
	}
	
	public int GetAge()		// Instance --> Instance
	{
		return age;
	} 		
}

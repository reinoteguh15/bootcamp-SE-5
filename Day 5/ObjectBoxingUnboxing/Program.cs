class Program
{
	static void Main()
	{
		// object boxing
		int x = 32;
		object y = x;
		Console.WriteLine($"y: {y}");
		
		// object unboxing
		int z = (int)y;
		Console.WriteLine($"z: {z}");
		
		int f = 33;
		object g = f;
		long h = (int)g;
		Console.WriteLine($"h: {h}");
	}
}

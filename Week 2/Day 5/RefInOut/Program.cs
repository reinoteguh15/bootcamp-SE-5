using System.Diagnostics.CodeAnalysis;

class Program
{
	static void Main()
	{
		// ref -> variable must be assigned first
		int x = 3;
		AddRef(ref x);
		Console.WriteLine($"x value from void Main(): {x} \n");

		// out -> variable can be unassigned, but outside the method must be assigned
		int y = 1;
		AddOut(out y);
		Console.WriteLine($"y value from void Main(): {y} \n");
		
		// in -> read only, used for optimization because not allocating new memory
		int z = 1;
		AddIn(in z);
		Console.WriteLine($"z value from void Main(): {z} \n");
	}
	
	// ref
	static void AddRef(ref int x)
	{
		x++;
		Console.WriteLine($"x value from void AddRef(): {x}");
	}
	
	// out -> pass by reference
	static void AddOut(out int y)
	{
		y = 5;
		Console.WriteLine($"y value from void AddOut(): {y}");
	}
	
	// in
	static void AddIn(in int z)
	{
		Console.WriteLine($"z value from AddIn(): {z}");
		int zValue = z + 3;
		Console.WriteLine($"zValue value from AddIn(): {zValue}");
	}
}
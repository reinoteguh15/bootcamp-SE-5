class Program
{
	static void Main()
	{
		// Upcast = assigning smaller size type to bigger size type
		// Implicit casting
		int x = 10;
		double y = x;
		Console.WriteLine(x);
		Console.WriteLine(y);
		
		// Downcast = assigning bigger size type to smaller size type
		double q = 10000000000;
		int z = (int) q;	//Explicit casting
		Console.WriteLine(q);
		Console.WriteLine(z);
	}
}
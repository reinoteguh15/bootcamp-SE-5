using DisposePattern;

class Program
{
	static void Main()
	{
		DestructorExample? obj1 = new();
		DestructorExample obj2 = new();
		
		obj1.Dispose();
		obj1 = null;
		
		Console.ReadKey();
		GC.Collect();
		GC.WaitForPendingFinalizers();
		
		Console.ReadKey();
	}
}
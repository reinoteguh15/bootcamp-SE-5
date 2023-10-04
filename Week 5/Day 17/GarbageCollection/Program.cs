using System;
using GarbageCollection;

class Program
{
	static void Main()
	{
		Console.WriteLine("Garbage Collector Generation");
		Console.WriteLine($"The number of generations are: {GC.MaxGeneration}");
		
		// GC.GetGeneration()
		Car myCar = new Car();
		Console.WriteLine($"\nThe generation of object myCar is {GC.GetGeneration(myCar)}");
		
		// GC.GetTotalMemory()
		Console.WriteLine($"Total memory: {GC.GetTotalMemory(false)}");
		
		// GC.Collect()
		GC.Collect(0);
		Console.WriteLine($"Garbage Collection in Generation 0 is: {GC.CollectionCount(0)}");
		Console.WriteLine($"Total memory: {GC.GetTotalMemory(false)}");
	}
}
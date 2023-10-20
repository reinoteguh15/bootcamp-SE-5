using ConsoleLogger;

class Program
{
	static void Main()
	{
		// Console Logger
		Console.WriteLine("Stating the program...");
		
		int a = 10;
		int b = 20;
		Console.WriteLine($"a: {a}, b: {b}");
		
		int sum = a + b;
		Console.WriteLine($"The sum of a and b is {sum}");
		
		Console.WriteLine("Program completed.");
		
		
		// File Logger
		Logger logger = new Logger();
		logger.Log("Starting the program...");
		logger.Log("Program completed.");
	}
}

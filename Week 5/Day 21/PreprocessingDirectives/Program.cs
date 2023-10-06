// Defaultly, C# will using DEBUG as preprocessing directives
// To run in other mode of P.D.:
// dotnet run -c YOUR_MODE

#define RELEASE
class Program
{
	static void Main()
	{
		Console.WriteLine("Start");
		
		#if DEBUG
		Console.WriteLine("Debug mode is activated...");
		#elif PRODUCTION
		Console.WriteLine("Production mode is activated...");
		#elif TEST
		#warning This is a test mode
		Console.WriteLine("Test mode is activated...");
		#else
		Console.WriteLine("Release mode is activated...");
		#endif
		
		Console.WriteLine("End");
	}
}
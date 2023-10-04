using System.Data;

class Program
{
	static void Main()
	{
		string x = "321abc";
		
		// Safety parsing -> using TryParse
		bool status = int.TryParse(x, out int result);
		Console.WriteLine($"result: {result}");
		Console.WriteLine($"status: {status}");
		
		// Non-safety parsing
		int resultInt = int.Parse(x);
		Console.WriteLine(resultInt);
	}
}

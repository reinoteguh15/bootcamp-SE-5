class Program
{
	static void Main()
	{
		Console.Write("Input your number: ");
		
		string? input = Console.ReadLine();
		try
		{
			int convertString = int.Parse(input);
			Console.WriteLine(convertString);
		}
		catch(Exception e)
		{
			Console.WriteLine($"{e.Message}");
		}
		finally
		{
			Console.WriteLine("This line is always executed no matter the errors appear or not.");
		}
	}
}
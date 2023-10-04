namespace StringTextHandling;
public class UpperLower
{
	public static void UpperAndLower(string? text)
	{
		string? myString = text;
		Console.WriteLine($"Text: {myString}");
		Console.WriteLine($"Lowercase: {myString.ToLower()}");
		Console.WriteLine($"Uppercase: {myString.ToUpper()} \n");
	}
}
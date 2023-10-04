namespace StringTextHandling;

public class EmptyString
{
	public static void CheckEmptyString()
	{
		string Empty = string.Empty;
		string empty = "";
		Console.WriteLine($"String 1: {Empty}");
		Console.WriteLine($"String 2: {empty}");
		Console.WriteLine($"String 1 == String 2: {Empty == empty} \n");
	}
}

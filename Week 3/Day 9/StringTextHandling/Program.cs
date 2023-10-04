using StringTextHandling;
class Program
{
	static void Main()
	{
		// Uppercase and Lowercase
		UpperLower.UpperAndLower("Hello");
				
		// Null and Empty String
		EmptyString.CheckEmptyString();
		
		// Accessing Character within String
		StringManipulation sm = new("Hello, world!");
		sm.AccessingCharacter(1);
		sm.SearchingCharacter("o");
		sm.ManipulatingString();
		sm.FormattingString();
		
	}
}
namespace StringTextHandling;

public class StringManipulation
{
	private string _text;
	public StringManipulation(string text)
	{
		_text = text;
	}
	public void AccessingCharacter(int charIndex)
	{
		char[] ca = _text.ToCharArray();
		string s = new string(ca);
		Console.WriteLine($"Text: {_text}");
		Console.WriteLine($"Index {charIndex}: {ca[charIndex]} (using Char Array)");
		Console.WriteLine($"Index {charIndex}: {s[charIndex]} (using String)");
	}

	public void SearchingCharacter(string string1)
	{
		Console.WriteLine($"{_text} ends with {string1}: {_text.EndsWith(string1)}");
		Console.WriteLine($"{_text} contains {string1}: {_text.Contains(string1)}");
		Console.WriteLine($"Index of space and punctuation marks in '{_text}': {_text.IndexOfAny(new char[] { ' ', ',' })}");
	}

	public void ManipulatingString()
	{
		Console.WriteLine($"Trim: {_text.Trim()}");
		Console.WriteLine($"Right Padding: {_text.PadRight(20, '*')}");
		Console.WriteLine($"Replace: {_text.Replace(" ", "...")}");
		Console.WriteLine($"Upper: {_text.ToUpper()}");
		Console.WriteLine($"Lower: {_text.ToLower()}");
		Console.WriteLine($"Substring (0, 5): {_text.Substring(0, 5)}");
	}

	public void FormattingString()
	{
		string composite = "Name={0,-20} Credit Limit={1,15:C}";
		Console.WriteLine(string.Format(composite, "Mary", 500));
		Console.WriteLine(string.Format(composite, "Elizabeth", 20000));
	}
}

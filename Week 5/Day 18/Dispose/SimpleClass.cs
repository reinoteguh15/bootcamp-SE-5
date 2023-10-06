namespace DisposePattern;

public class SimpleClass
{
	~SimpleClass()
	{
		Console.WriteLine("SimpleClass is destroyed...");
	}
}

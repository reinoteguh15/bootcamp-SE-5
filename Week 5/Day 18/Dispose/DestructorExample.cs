namespace DisposePattern;
using DisposePattern;
class DestructorExample : IDisposable
{
	SimpleClass? simple = new SimpleClass();
	
	public DestructorExample()
	{
		Console.WriteLine("Destructor Object is created...");
	}
	
	public void Dispose()
	{
		simple = null;
	}
	~DestructorExample()
    {
        Dispose();
        Console.WriteLine("Destructor Object destroyed");
    }
}

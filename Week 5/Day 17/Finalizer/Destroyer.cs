namespace Finalizer;
public class Destroyer
{
	~Destroyer()
	{
		System.Diagnostics.Trace.WriteLine($"The finalizer is executing.");
	}
}
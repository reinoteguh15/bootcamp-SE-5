namespace Multithreading;

public class Work
{	
	public static void DoWork(object? arg)
	{
		if (arg == null)
		{
			return;
		}
		
		string message = (string)arg;
		Thread.Sleep(1000);
		Console.WriteLine(message);
	}
}

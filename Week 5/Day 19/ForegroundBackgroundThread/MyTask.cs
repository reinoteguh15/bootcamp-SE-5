namespace ForegroundBackgroundThread;

public class MyTask
{
	public static void DoWork(object? args)
	{
		if (args == null)
		{
			return;
		}
		string message = (string)args;
		
		for (int i  = 0; i < 5; i++)
		{
			Thread.Sleep(100);
			Console.Write(message);
			Console.WriteLine(" Thread is running");
		}
	}
}

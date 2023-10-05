namespace AllAboutTask;

public class MyAction
{
	public static int GetRandomNumber()
	{
		int threadId = Thread.CurrentThread.ManagedThreadId;
		bool threadPool = Thread.CurrentThread.IsThreadPoolThread;
		
		Thread.Sleep(1000);
		Random random = new();
		int randomNumber = random.Next(1,100);
		Console.WriteLine($"The random number is {randomNumber}");
		return randomNumber;
	}
}

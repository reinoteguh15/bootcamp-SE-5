using ForegroundBackgroundThread;
using System.Diagnostics;
class Program
{
	static void Main()
	{		
		// Foreground Thread --> still executed although the main thread is completed
		// var fgThread = new Thread(MyTask.DoWork);
		// fgThread.Start("Foreground");
		
		// Background Thread --> it will terminated if the main thread is completed
		var bgThread = new Thread(MyTask.DoWork);
		bgThread.IsBackground = true;
		bgThread.Start("Background");
		
		// Main Thread
		for (int i = 0; i < 2; i++)
		{
			Thread.Sleep(100);
			Console.WriteLine("Main Thread is running...");
		}
	}
}
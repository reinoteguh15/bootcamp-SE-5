using Multithreading;
using System.Diagnostics;

class Program
{
	public static void DoWork()
	{
		Console.WriteLine("Doing the work...");
		Thread.Sleep(1000);
		Console.WriteLine("Done!");
	}
	static void Main()
	{
		var watch1 = Stopwatch.StartNew();

		DoWork();
		DoWork();
		
		watch1.Stop();
		Console.WriteLine($"It took {watch1.Elapsed.Seconds} second(s) to complete the \n");
		
		// Using thread class for multithreading
		var watch2 = Stopwatch.StartNew();
		
		var t1 = new Thread(DoWork);
		var t2 = new Thread(DoWork);
		
		// Start both threads
		t1.Start();
		t2.Start();
		
		// Wait for both threads to complete
		t1.Join();
		t2.Join();
	
		watch2.Stop();
		Console.WriteLine($"It took {watch2.Elapsed.Seconds} second(s) to complete the work.\n");
		
		var watch3 = Stopwatch.StartNew();
		
		var t3 = new Thread(Work.DoWork);
		var t4 = new Thread(Work.DoWork);
		
		// Start both threads
		t3.Start("Hello!");
		t4.Start("Bye!");
		
		// Wait for both threads to complete
		t3.Join();
		t4.Join();
	
		watch3.Stop();
		Console.WriteLine($"It took {watch3.Elapsed.Seconds} second(s) to complete the work.");
	
	}
	
}
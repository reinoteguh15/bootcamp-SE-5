using System.Diagnostics;
namespace AnotherAsyncAwait;

public static class School
{
	public static void Demo()
	{
		Stopwatch stopwatch = new();
		stopwatch.Start();
		
		Task task1 = StartSchool();
		Task task2 = TeachClass11();
		Task task3 = TeachClass12();
		
		Task.WaitAll(task1, task2, task3);
		stopwatch.Stop();
		
		Console.WriteLine($"Execution time: {stopwatch.Elapsed.Seconds} seconds");
		
	}
	
	public static async Task StartSchool()
	{
		await Task.Run(() => 
		{
			Console.WriteLine("School Started...");
			Thread.Sleep(8000);
		});
	}
	
	public static async Task TeachClass11()
	{
		await Task.Run(() => 
		{
			Thread.Sleep(3000);
			Console.WriteLine("Taught class 11");
		});
	}
	
	public static async Task TeachClass12()
	{
		await Task.Run(() => 
		{
			Thread.Sleep(2000);
			Console.WriteLine("Taught class 12");
		});
	}
}

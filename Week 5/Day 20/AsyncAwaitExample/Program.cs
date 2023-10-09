using System;
using System.Threading;

class Program
{
	static async Task Main()
	{
		Console.WriteLine("Starting the main process...");
		await DoWorkAsync();
		Console.WriteLine("Main process is completed...");
	}
	
	static async Task DoWorkAsync()
	{
		Console.WriteLine("Starting the asynchronous work...");
		await Task.Delay(2000);
		Console.WriteLine("Asynchronous work is completed...");
	}
}
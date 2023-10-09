using System;
using System.Threading;
using AnotherAsyncAwait;

class Program
{
	static void Main()
	{
		Console.WriteLine("Main program is started...");
		
		School.Demo();
		Console.ReadLine();
		
		Console.WriteLine("Main program is finished...");
	}
}
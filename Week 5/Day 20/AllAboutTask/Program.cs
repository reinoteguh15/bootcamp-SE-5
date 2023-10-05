using AllAboutTask;
class Program
{
	static void Main()
	{
		Console.WriteLine($"(Thread ID: {Thread.CurrentThread.ManagedThreadId} - MAIN) Main thread is started...");
		Console.WriteLine("Hello from Main Thread!\n");
		
		Task task1 = new(() => {
			Console.WriteLine($"(Thread ID: {Thread.CurrentThread.ManagedThreadId} - Task {Task.CurrentId})");
			MyAction.GetRandomNumber();
		});
		task1.Start();
		task1.Wait();
		
		Task task2 = Task.Run(() => {
			Console.WriteLine($"\n(Thread ID: {Thread.CurrentThread.ManagedThreadId} - Task {Task.CurrentId})");
			MyAction.GetRandomNumber();
		});
		
		Task<int> task3 = Task.Run(() =>  MyAction.GetRandomNumber());
		Console.WriteLine($"\n(Thread ID: {Thread.CurrentThread.ManagedThreadId} - MAIN) Task 3 get number {task3.Result} from the GetRandomNumber()");
		Console.WriteLine($"(Thread ID: {Thread.CurrentThread.ManagedThreadId} - MAIN) Main thread is finished");
		
		// Console.WriteLine($"Task 1 get the number {task1.Result}")
		
		
		// Hold the main thread to finish the task using Console.Read()
		Console.Read();
	}
}
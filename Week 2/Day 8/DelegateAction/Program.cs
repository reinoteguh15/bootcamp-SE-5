class Program
{
	static void Main()
	{
		// Accept all method that has string input
		Action<string> myAction = Printer;
		myAction += Greeter;
		myAction.Invoke("rei");
	}
	static void Printer(string x)
	{
		Console.WriteLine(x);
	}
	static void Greeter(string x)
	{
		Console.WriteLine($"Hello! Good morning {x}");
	}
}
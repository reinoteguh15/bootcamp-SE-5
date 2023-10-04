class Program
{
	static void Main()
	{
		// input1 = int, input2 = int, return int
		Func<int, int, int> myInt = Adder;
		// myInt += Printer;	error because wrong return type
		int intResult = myInt.Invoke(3,4);
		Console.WriteLine($"{intResult} ({intResult.GetType()})");
		
		//input1 = int, input2 = int, return string
		Func<int, int, string> myString = Printer;
		string stringResult = myString.Invoke(10,5);
		Console.WriteLine($"{stringResult} ({stringResult.GetType()})");
	}
	static int Adder(int a, int b)
	{
		return a + b;
	}
	static string Printer(int a, int b)
	{
		return (a + b).ToString();
	}
}

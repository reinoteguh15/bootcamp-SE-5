class Program
{
	static void Main()
	{
		// Anonymous Delegate / Lambda Expression of Function
		Func<int,int,int> myInt1 = (int a, int b) => a + b;
		Console.WriteLine($"Lambda function myInt1 result: {myInt1.Invoke(3,4)}");
		
		Func<int,int,int> myInt2 = (int a, int b) =>
		{
			int c = a + b;
			return c;
		};
		Console.WriteLine($"Lambda function myInt2 result: {myInt2.Invoke(4,5)} \n");
		
		Func<string> myString1 = () => "Hello world!";
		Func<string> myString2 = () => "How are you?";
		Func<string>? resultString = myString1 + myString2;
		Console.WriteLine($"{resultString.Invoke()} \n");	// it will print only the last added method
		
		Delegate[] myDelegate = resultString.GetInvocationList();
		foreach(Func<string> func in myDelegate)
		{
			Console.WriteLine(func.Invoke());
		}
		Console.WriteLine();

        resultString -= myString2;
		myDelegate = resultString.GetInvocationList();
		foreach(Func<string> func in myDelegate)
		{
			Console.WriteLine(func.Invoke());
		}
		Console.WriteLine();
		
		// Anonymous Delegate/ Lambda Expression of Action
		Action<string> myAction = (string x) => Console.WriteLine(x);
		myAction.Invoke("Hellow... \n");
		
		Action myAction2 = () => Console.WriteLine("Darling..Ohayou!");
		myAction2.Invoke();
	}
}
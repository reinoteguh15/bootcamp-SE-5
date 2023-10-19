namespace Calculation;

class Program
{
	static void Main()
	{
		NumberCalculation numberCalculation = new();
		int a = 10;
		int b = 15;
		
		Console.WriteLine($"Addition of {a} and {b} is {numberCalculation.Add(a, b)}");
			Console.WriteLine($"Subtraction of {a} and {b} is {numberCalculation.Subtract(a, b)}");
			Console.WriteLine($"Multiplication of {a} and {b} is {numberCalculation.Multiply(a, b)}");
			Console.WriteLine($"Division of {a} and {b} is {numberCalculation.Divide(a, b)}");
	}
}

public class NumberCalculation
{
	public int Add (int a, int b)
	{
		return a + b;
	}
	public int Subtract (int a, int b)
	{
		return a - b;
	}
	public int Multiply (int a, int b)
	{
		return a * b;
	}
	public int Divide (int a, int b)
	{
		return a / b;
	}
}
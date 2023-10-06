static class Program
{
	static void Main()
	{
		double num1 = 4.0;
		double num2 = 2.5;
		double result = Add(num1, num2);
		
		Console.WriteLine($"{num1} + {num2} = {result}");
		
		var x = Console.ReadLine();
		Console.WriteLine(x);
	}
	
	static double Add(double a, double b)
	{
		return a * b; 
	}
}
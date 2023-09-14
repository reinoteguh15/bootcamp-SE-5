namespace DelegateReturnValue;

public class Calculator
{
	public static int Addition(int a, int b)
	{
		return a + b;
	}
	public static int Subtraction(int a, int b)
	{
		return a - b;
	}
	public static int Multiplication(int a, int b)
	{
		return a * b;
	}
	public static int Division(int a, int b)
	{
		if(b != 0)
		{
			return a/b;
		}
		else
		{
			Console.WriteLine("Can't divide by 0");
		}
		return 0;
	}
}

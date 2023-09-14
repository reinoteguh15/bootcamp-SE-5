using DelegateReturnValue;

public delegate int MyCalculator(int value1, int value2);
class Program
{
	static void Main()
	{
		MyCalculator calculator = Calculator.Addition;
		calculator += Calculator.Subtraction;
		calculator += Calculator.Multiplication;
		calculator += Calculator.Division;
		
		Delegate[] resultDelegate = calculator.GetInvocationList();
		
		List<int> resultList = new();
		foreach(MyCalculator calc in resultDelegate)
		{
			resultList.Add(calc.Invoke(10,5));
		}
		
		foreach(int value in resultList)
		{
			Console.WriteLine(value);
		}
	}
}

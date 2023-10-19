using NUnit.Framework;
using Calculation;

namespace Calculation.Test;

[TestFixture]
public class NumberCalculationTests
{
	private NumberCalculation numberCalculation;
	
	[SetUp]
	// Each test will setup a new instance 
	public void Setup()
	{
		numberCalculation = new();
	}
	
	[Test]
	public void Add_AdditionOfTwoNumbers()
	{
		// Arrange
		int a = 10;
		int b = 15;
		int expected = 25;
		
		// Act
		int actual = numberCalculation.Add(a, b);
		
		// Assert
		Assert.AreEqual(expected, actual);
	}
	
	[Test]
	public void Subtract_SubtractionOfTwoNumbers()
	{
		int a = 10;
		int b = 15;
		int expected = -5;
		
		int actual = numberCalculation.Subtract(a, b);
		
		Assert.AreEqual(expected, actual);
	}
	
	[Test]
	public void Multiply_MultiplicationOfTwoNumbers()
	{
		int a = 10;
		int b = 15;
		int expected = 150;
		
		int actual = numberCalculation.Multiply(a, b);
		
		Assert.AreEqual(expected, actual);
	}
	
	[Test]
	public void Divide_DivisionOfTwoNumbers()
	{
		int a = 10;
		int b = 2;
		int expected = 5;
		
		int actual = numberCalculation.Divide(a, b);
		
		Assert.AreEqual(expected, actual);
	}
	
	[Test]
	public void Divide_ShouldThrowDivideByZeroException_DivideByZero()
	{
		int a = 10;
		int b = 0;
				
		Assert.Throws<DivideByZeroException>(() => numberCalculation.Divide(a, b));
	}
}
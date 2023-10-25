using System;

namespace BuilderDesignPatternExample;

class Program
{
	static void Main()
	{
		Director director = new();
		ConcreteBuilder builder = new();
		director.Builder = builder;
		
		Console.WriteLine("Standard basic product: ");
		director.BuildMinimalViableProduct();
		Console.WriteLine(builder.GetProduct().ListParts());
		
		Console.WriteLine("Standard full featured product: ");
		director.BuildFullFeatureProduct();
		Console.WriteLine(builder.GetProduct().ListParts());
		
		Console.WriteLine("Custom product:");
		builder.BuildPartA();
		builder.BuildPartB();
		Console.WriteLine(builder.GetProduct().ListParts());
	}
}
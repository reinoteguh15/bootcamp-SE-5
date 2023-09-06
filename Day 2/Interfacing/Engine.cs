namespace CarEngine;

// Interface
public interface IEngine
{
	void EngineRun();
}

class PistonEngine : IEngine
{
	public void EngineRun()
	{
		Console.WriteLine("Piston engine is running");
	}
}

class DieselEngine : IEngine
{
	public void EngineRun()
	{
		Console.WriteLine("Diesel engine is running");
	}
}

class ElectricEngine : IEngine
{
	public void EngineRun()
	{
		Console.WriteLine("Electric engine is running");
	}
}


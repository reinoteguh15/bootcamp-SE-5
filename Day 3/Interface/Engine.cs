namespace CarEngineInterface;

public interface IEngines
{
	void EngineStart();
}

public interface IElectrics
{
	void Charge();
}

public class PistonEngines : IEngines
{
	public void EngineStart()
	{
		Console.WriteLine("Piston Engine is starting...");
	}
}

public class ElectricEngines: IEngines, IElectrics
{
	public void EngineStart()
	{
		Console.WriteLine("Electric Engine is starting...");
	}	
	public void Charge()
	{
		Console.WriteLine("Electric Engine is charging...");
	}
}
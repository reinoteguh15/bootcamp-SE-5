namespace CarEngine;

class Car
{
	public IEngine engine;
	
	public Car(IEngine engine)
	{
		this.engine = engine;
	}
	
	public void StartEngine()
	{
		Console.WriteLine("Starting Engine...");
		engine.EngineRun();
	}
}


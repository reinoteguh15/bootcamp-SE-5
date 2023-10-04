using CarEngineInterface;

class Program
{
	static void Main()
	{
		PistonEngines piston = new PistonEngines();
		piston.EngineStart();
		
		ElectricEngines electric = new ElectricEngines();
		electric.EngineStart();
		electric.Charge();
		
		IEngines engines = electric;
		engines.EngineStart();
		// engines.Charge(); //error because IEngines doesn't have 'Charge' method
		
		IElectrics electrics = electric;
		electrics.Charge();
	}
}

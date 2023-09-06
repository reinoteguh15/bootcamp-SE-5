using CarEngine;

class Program
{
	static void Main()
	{
		PistonEngine piston = new PistonEngine();
		DieselEngine diesel = new DieselEngine();
		ElectricEngine electric = new ElectricEngine();

		Car mobil = new Car(electric);
		mobil.StartEngine();
	}
}
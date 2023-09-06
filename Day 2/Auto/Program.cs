using Auto;

class Program
{
	static void Main()
	{
		Engine engine = new Engine("Rolls Royce", 8, 2500);
		
		Car car = new Car(engine, "Volkswagen", 2013);
		
		car.EngineCheck();
		car.BrandCheck();
		car.YearCheck();
	}
}

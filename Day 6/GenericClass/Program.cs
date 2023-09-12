using GenericClass;

class Program
{
	static void Main()
	{
		Car<Tire, int> car2 = new Car<Tire,int>(new Tire(),3);
		car2.Check();
	}
}
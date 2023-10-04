using System.Collections;
using NonGenericCollection;

class Program
{
	static void Main()
	{
		// Not safety collection because accept all object
		ArrayList list = new ArrayList();
		list.Add(3);
		list.Add("3");
		list.Add(true);
		list.Add(3.0);
		list.Add(new Car());
		
		// Must be unboxed
		// list[4].CarRun(); 
		((Car)list[4]).CarRun();
		Console.WriteLine(list[0]);
		// ((Car)list[1]).CarRun();	// unable to cast string to Car
	}
}

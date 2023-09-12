using GenericConstraints;

class Program
{
	static void Main()
	{
		// T = class
		// Checker(3);		// error, becuase int is struct
		Checker("3");
		// Checker(true);	// error, becuase bool is struct
		// Checker(3.0f);	// error, because float is struct
		// Checker(3.0M);		// error, because decimal is struct
		Checker(new Car());
		Checker(new Motorcycle());
		
		// T = class, T2 = struct
		Checker("Hello", 2);
		
	}
	
	static void Checker<T>(T a) where T: class
	{
		
	}
	
	static void Checker<T, T2>(T a, T2 b)
	where T: class
	where T2: struct
	{
		
	}
}
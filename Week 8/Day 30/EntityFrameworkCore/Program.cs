using EFDatabase;

namespace ProgramEFCore;
partial class Program
{
	static void Main()
	{
		using (Northwind db = new())
		{
			Console.WriteLine($"Name: {db.Database}");
			Console.WriteLine($"Database: {db.Database.ProviderName}");
			Console.WriteLine($"Database Connection: {db.Database.CanConnect()}\n");
			
			QueryingCategories();
		}
	}
}
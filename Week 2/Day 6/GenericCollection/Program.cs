using GenericCollection;

partial class Program
{
	static void Main()
	{
		// List -> Generic<T>
		List<ICar> list = new List<ICar>();
		list.Add(new Daihatsu());
		list.Add(new Honda());
		list.Add(new Toyota());
		
		list[0].CarRun();
		list[1].CarRun();
		list[2].CarRun();
		
		// Dictionary -> Generic<T a, T2 b>
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		dictionary.Add(1, "Satu");
		dictionary.Add(2, "Dua");
		// dictionary.Add(1, "Tiga");	//exception because same key item added
	}
}
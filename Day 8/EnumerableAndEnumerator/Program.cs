using System.Collections;
class Program
{
	static void Main()
	{
		List<int> arrayList = new List<int>() {1, 3, 5, 7};
		Console.WriteLine("List apply the IEnumerable contract, so it is iterable (using foreach): ");
		foreach (var number in arrayList)
		{
			Console.Write($"{number} ");
		}
		
		IEnumerator iterator = arrayList.GetEnumerator();
		Console.WriteLine("\nEnumerator:");
		while(iterator.MoveNext())
		{
			Console.WriteLine(iterator.Current);
		}
		
		Console.WriteLine("Manual Iterator:");
		iterator.Reset();
		iterator.MoveNext();
		Console.WriteLine(iterator.Current);
		iterator.MoveNext();
		Console.WriteLine(iterator.Current);
		iterator.MoveNext();
		Console.WriteLine(iterator.Current);
		iterator.MoveNext();
		Console.WriteLine(iterator.Current);
		// iterator.MoveNext();		error because it has reached the last index
		// Console.WriteLine(iterator.Current);
	}
}
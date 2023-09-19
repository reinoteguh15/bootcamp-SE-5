class Program
{
	static void Main()
	{
		int[] myIntArray = new int[5] {1,2,3,4,5};
		myIntArray[4] = 100;
		for(int i = 0; i < myIntArray.Length; i++)
		{
			Console.Write($"{myIntArray[i]} ");
		}
		Console.WriteLine();
		
		List<int> myIntList = new List<int>();
		myIntList.Add(1);
		myIntList.Add(2);
		myIntList.Add(3);
		myIntList.Add(4);
		for(int j = 0; j < myIntList.Count; j++)
		{
			Console.Write($"{myIntList[j]} ");
		}
		Console.WriteLine();
		
		HashSet<int> myHashSet = new();
		myHashSet.Add(1);
		myHashSet.Add(2);
		myHashSet.Add(3);
		myHashSet.TryGetValue(1, out int result);
		Console.WriteLine(result);
	}
}

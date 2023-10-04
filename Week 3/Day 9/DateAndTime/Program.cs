using System.Text;

class Program
{
	static void Main()
	{
		StringBuilder sb = new StringBuilder();
		
		sb.Append('*', 5).Append("Welcome to DogeCoin mining site").Append('*', 5);
		sb.AppendLine();
		sb.Append('=', 40);
		sb.AppendLine();
		sb.AppendLine("Mining in progress...");
		Console.WriteLine(sb.ToString());
		
		Console.Write("Enter duration (in seconds): ");
		string? input = Console.ReadLine();
		int.TryParse(input, out int duration);
		
		int total = 0;
		for (int i = 1; i <= duration; i++)
		{
			DateTime now = DateTime.Now;
			Random rnd = new Random();
			int randNum = rnd.Next(0,25);
			
			Console.WriteLine($"{now} - Got {randNum}$ DogeCoin");		
			total += randNum;	
			
			Thread.Sleep(1000);
		}
		Console.WriteLine($"\nSuper! Now you have {total}$ DogeCoin...\n");
	}
}
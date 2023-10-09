using System.IO;
using System.Text;

class Program
{
	static void Main()
	{		
		using (FileStream fs = new(@"./bootcamp.txt", FileMode.Create, FileAccess.Write))
		{
			string myString = "Hello world!";
			byte[] bytes = Encoding.UTF8.GetBytes(myString);
			fs.Write(bytes, 0, bytes.Length);
		}
		
		using (FileStream fs = new(@"./bootcamp.txt", FileMode.Open, FileAccess.Read))
		{
			byte[] bytes = new byte[fs.Length];
			fs.Read(bytes, 0, bytes.Length);
			string myString = Encoding.UTF8.GetString(bytes);
			Console.WriteLine(myString);
		}
		
		using (FileStream fs = new(@"./bootcamp.txt", FileMode.Open, FileAccess.Read, FileShare.None))
		{
			while(true)
			{
				
			}
		}
	}
}
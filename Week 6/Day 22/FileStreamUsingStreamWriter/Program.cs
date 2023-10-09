using System.IO;
using System.Text;
using FileStreamUsingStreamWriter;

class Program
{
	static void Main()
	{
		FileModifier fm = new();
		
		string? myString = "Hello";
		string? filePath = @"./bootcamp.txt";
		fm.WriteUsingSW(filePath, myString);
		
		string? myString2 = "This string is written in the end line of the file";
		fm.WriteEndLine(filePath, myString2);
		
		string? myString3 = "This string is appended";
		fm.WriteAppend(filePath, myString3);
	}
}
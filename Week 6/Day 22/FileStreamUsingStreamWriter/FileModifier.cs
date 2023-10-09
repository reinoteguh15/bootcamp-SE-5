namespace FileStreamUsingStreamWriter;

public class FileModifier
{
	private string? _filePath;
	private string? _stringToWrite;
	public FileModifier()
	{
	
	}
	
	public void WriteUsingSW(string? file, string? text)
	{
		_filePath = file;
		_stringToWrite = text;
		
		using (FileStream fs = new(_filePath!, FileMode.OpenOrCreate, FileAccess.ReadWrite))
			using (StreamWriter sw = new StreamWriter(fs))
			{
				sw.WriteLine(_stringToWrite);
			}
	}
	
	public void WriteEndLine(string? file, string? text)
	{
		_filePath = file;
		_stringToWrite = text;
		
		using (FileStream fs = new(_filePath!, FileMode.OpenOrCreate, FileAccess.ReadWrite))
			using(StreamWriter sw = new StreamWriter(fs))
			{
				sw.BaseStream.Position = fs.Seek(0, SeekOrigin.End);
				sw.WriteLine(_stringToWrite);
			}
	}
	
	public void WriteAppend(string? file, string? text)
	{
		_filePath = file;
		_stringToWrite = text;
		
		using (FileStream fs = new(_filePath!, FileMode.Append, FileAccess.Write))
			using (StreamWriter sw = new StreamWriter(fs))
			{
				sw.WriteLine(_stringToWrite);
			}
	}
}

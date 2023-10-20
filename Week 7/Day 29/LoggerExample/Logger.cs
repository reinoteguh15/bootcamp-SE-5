namespace ConsoleLogger;

public class Logger
{
	private string logFilePath = "./log.txt";
	
	public void Log(string message)
	{
		using (StreamWriter writer = new StreamWriter(logFilePath, true))
		{
			writer.WriteLine($"{DateTime.Now} - {message}");
		}
	}
}

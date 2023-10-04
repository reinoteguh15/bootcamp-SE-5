using System.ComponentModel.DataAnnotations;

class Program
{
	public static void CheckHTTPStatus(string url)
	{
		HttpClient client = new();
		var response = client.GetAsync(url).Result;
		Console.WriteLine($"The HTTP status code of {url} is {response.StatusCode}");
	}
	
	static void Main()
	{
		List<string> urls = new()
		{
			"https://www.google.com",
			"https://www.bing.com",
			"https://www.yahoo.com"
		};
		
		foreach (string url in urls)
		{
			ThreadPool.QueueUserWorkItem((state) => CheckHTTPStatus(url));
		}
		Console.Read();
		
		
		
	}
}
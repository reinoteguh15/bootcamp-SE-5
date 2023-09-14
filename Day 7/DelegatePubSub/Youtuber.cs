namespace DelegatePubSub;

public class Youtuber
{
	public delegate void MyDelegate(string uploader, string message);
	private string? _name;
	private string? _message;
	public MyDelegate? subscriber;
	
	public Youtuber(string name, string message)
	{
		_name = name;
		_message = message;
	}
	public void UploadVideo()
	{
		Console.WriteLine($"(YouTuber) {_name} is uploading video...");
		if(subscriber != null)
		{
			subscriber.Invoke(_name, _message);
		}
	}
}

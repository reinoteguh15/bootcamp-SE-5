namespace DelegatePubSub;

public class Subscriber
{
	public void GetNotification(string youtuber, string message)
	{
		Console.WriteLine($"(Subscriber) Get notification from {youtuber}: {message}");
	}
}

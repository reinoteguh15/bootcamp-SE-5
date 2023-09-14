namespace EventHandlerYoutuber;

public class Subscriber
{
	public void Notification(object? sender, EventArgs e)
	{
		Console.WriteLine($"(Subscriber) You got a new notification from {sender} \n");
	}
}

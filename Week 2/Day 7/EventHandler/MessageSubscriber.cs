namespace EventHandlerYoutuber;

public class MessageSubscriber
{
	public void Notification(object? sender, EventData e)
	{
		Console.WriteLine($"(Premium Subscriber - ID. {e.GetID()}) You get message: '{e.GetMessage()}' from Youtuber {sender} \n");
	}
}

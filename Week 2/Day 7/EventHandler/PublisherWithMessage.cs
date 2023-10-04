namespace EventHandlerYoutuber;

public class PublisherWithMessage : Publisher
{
	public EventHandler<EventData> ?messageSubs;
	public PublisherWithMessage(string name) : base(name)
	{
	}
	
	public override void SendNotification()
	{
		EventData ed = new EventData("Thanks for subscribing!", 105);
		if(messageSubs != null)
		{
			messageSubs.Invoke(this, ed);
		}
	}
	
}

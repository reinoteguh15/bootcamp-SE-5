namespace EventHandlerYoutuber;

public class Publisher
{
	public EventHandler? subscriber;
	protected string? _name;
	
	public Publisher(string name)
	{
		_name = name;
	}
	public void UploadVideo()
	{
		Console.WriteLine($"(MyTuber) {_name} is uploading video...");
		SendNotification();
	}
	public virtual void SendNotification()
	{
		if(subscriber != null)
		{
			subscriber.Invoke(this, EventArgs.Empty);
		}
	}
	public void EventClear()
	{
		subscriber = null;
	}
	public override string? ToString()
	{
		return _name;
	}
}

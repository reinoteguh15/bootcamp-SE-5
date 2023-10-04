namespace EventHandlerYoutuber;

public class EventData : EventArgs
{
	private string? _message;
	private int _id;
	
	public EventData(string message, int id)
	{
		_message = message;
		_id = id;
	}
	public string? GetMessage()
	{
		return _message;
	}
	public int GetID()
	{
		return _id;
	}
}

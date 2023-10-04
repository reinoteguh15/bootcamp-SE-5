namespace InterfaceSeggregation;

public interface IPlayer
{
	string GetName();
	int GetID();
}

public interface IOnline
{
	string GetUsername();
	string GetServer();
}
public class KarambolPlayer : IPlayer
{
	public string GetName()
	{
		return "karambol nih bos";
	}
	public int GetID()
	{
		return 10;
	}
}

public class ValorantPlayer : IPlayer, IOnline
{
	public string GetName()
	{
		return "valorant";
	}
	public int GetID()
	{
		return 15;
	}
	public string GetUsername()
	{
		return "bociljago123";
	}
	public string GetServer()
	{
		return "Saranjana";
	}
}


namespace LoggerFactoryExample;

public interface ICard
{
	int GetValue();
	string GetDescription();
	CardStatus GetStatus();
	void SetStatus(CardStatus status);
	bool Equals(object? card);
	int GetHashCode();
}

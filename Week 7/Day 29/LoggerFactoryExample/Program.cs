using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using LoggerFactoryExample;

partial class Program
{
	static void Main()
	{
		ManualCreation();
		DependencyInjection();
	}
	static void NoLog()
	{
		IPlayer player = new Player("player1");
		IBoard board = new Board(2);
		GameController game = new GameController(player, board);
	}
}
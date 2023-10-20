using log4net;
using log4net.Config;

namespace Log4NetExample;

public class GameRunner
{
	private static readonly ILog logger = LogManager.GetLogger(typeof(GameRunner));
	
	public static void Message(string args)
	{
		logger.Info(args);
	}
}

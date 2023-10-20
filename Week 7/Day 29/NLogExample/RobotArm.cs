using NLog;

namespace NLogExample;

public class RobotArm
{
	private static Logger logger = LogManager.GetCurrentClassLogger();
	
	public void Connect()
	{
		// Connect to the robot arm
		logger.Debug("Connecting to the robot arm...");
	}
	public void MoveTo(int x, int y, int z)
	{
		// Move the robot arm to the specified position
		logger.Trace($"Moving the robot arm to ({x}, {y}, {z})");
	}
	public void Grab()
	{
		logger.Trace("Grabbing object with robot arm");
	}
	public void Release()
	{
		logger.Trace("Releasing object from the robot arm");
	}
	public void Disconnect()
	{
		logger.Info("Disconnecting from the robot arm");
	}
}

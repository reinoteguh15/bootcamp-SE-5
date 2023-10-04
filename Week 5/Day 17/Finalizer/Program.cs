using Finalizer;

class Program
{
	static void Main()
	{
		Destroyer? destroyer = new Destroyer();
		destroyer = null;
	}
}

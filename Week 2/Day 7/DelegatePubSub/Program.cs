using DelegatePubSub;

class Program
{
	static void Main()
	{
		Youtuber youtuber = new("PewDiePie", "Don't forget to like, share, and subscribe");
		Subscriber sub1 = new Subscriber();
		
		youtuber.subscriber += sub1.GetNotification;
		
		youtuber.UploadVideo();		
	}
}
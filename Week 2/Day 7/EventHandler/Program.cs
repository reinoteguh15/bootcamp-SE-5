using EventHandlerYoutuber;

class Program
{
	static void Main()
	{
		Console.WriteLine("Welcome to MyTube feeds!");
		Console.WriteLine("=====================================================");
		
		Publisher yt1 = new("JessNoLimit");
		Publisher yt2 = new("Bang Jago");
		Publisher yt3 = new("WongToxic");
		PublisherWithMessage youtuber1 = new("Gudang Tutorial");

		Subscriber sub1 = new Subscriber();
		MessageSubscriber subs1 = new MessageSubscriber();

		// yt1 is subscribed by sub1, so sub1 will get notified
		yt1.subscriber += sub1.Notification;
		yt1.UploadVideo();
		
		//yt2 is subscribed by sub1, so sub1 will get notified
		yt2.subscriber += sub1.Notification;
		yt2.UploadVideo();
		
		//yt3 is not subscribed by anyone
		yt3.UploadVideo();
		Console.WriteLine();
		
		//youtuber1 get subscribed by subs1, so it will get notified
		youtuber1.messageSubs += subs1.Notification;
		youtuber1.UploadVideo();
	}


}

using DelegateBasic;
public delegate void MyDelegate();
class Program
{
	static void Main()
	{
		ActionForDelegate action = new();
		
		MyDelegate myDel = action.Printer;
		myDel += action.Crusher;
		myDel += action.Subscriber;
		
		Invoker(myDel);
	}
	
	static void Invoker(MyDelegate x)
	{
		x.Invoke();
	}
}
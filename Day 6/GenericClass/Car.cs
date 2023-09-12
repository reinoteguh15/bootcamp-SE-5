namespace GenericClass;

class Car<T, T2> where T : ITire where T2 : struct
{
	public T? name;
	public T2 year;
	
	public Car(T a, T2 b)
	{
		name = a;
		year = b;
	}
	
	public void Check()
	{
		name.CheckTire();
	}
	
	public T2 CheckYear()
	{
		return year;
	}
}

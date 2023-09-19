using System.Text;

namespace LecturePresence;

public class Student
{
	private string? _name;
	private int _id;
	private bool _isPresence = false;
	
	public Student(string name, int id)
	{
		_name = name;
		_id = id;
	}
	
	public bool Presence()
	{
		_isPresence = true;
		return _isPresence;
	}
	
	public void GetPresenceList()
	{
		StringBuilder sb = new StringBuilder();
		sb.Append(_name + " ");
		sb.Append(_id + " ");
		sb.Append(_isPresence + " ");
		Console.WriteLine(sb.ToString());
	}
}

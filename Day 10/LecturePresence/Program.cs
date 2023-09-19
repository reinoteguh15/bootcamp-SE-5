using LecturePresence;

class Program
{
	static void Main()
	{
		Student firstStudent = new("Abdul", 104);
		Student secondStudent = new("Bayu", 105);
		Student thirdStudent = new("Combro", 106);
		Student fourthStudent = new("Dedi", 204);
		
		firstStudent.Presence();
		secondStudent.Presence();
		fourthStudent.Presence();
		
		List<Student> lectureOne = new List<Student>();
		lectureOne.Add(firstStudent);
		lectureOne.Add(secondStudent);
		lectureOne.Add(thirdStudent);
		lectureOne.Add(fourthStudent);
		
		Console.WriteLine("Welcome to the Programming Class...");
		Console.WriteLine("Here's today's class attendance: ");
		Console.WriteLine("Name  ID  Presence");
		Console.WriteLine("-------------------");
		foreach(var student in lectureOne)
		{
			student.GetPresenceList();
		}
		
	}
}

using ClassRoomNet60;

class Program
{
    static void Main(string[] args)
    {
        ClassRoom classRoom = new ClassRoom();
        
        classRoom.ClassName = "3Q";
        classRoom.SemesterStart = DateTime.Today;
        
        Student mathias = new Student("Mathias", 8, 11);
        Student sebastian = new Student("Sebastian", 4, 15);
        
        classRoom.StudentList.Add(mathias);
        classRoom.StudentList.Add(sebastian);

        foreach (var s in classRoom.StudentList)
        {
            Console.WriteLine(s.Name);
        }
    }
}

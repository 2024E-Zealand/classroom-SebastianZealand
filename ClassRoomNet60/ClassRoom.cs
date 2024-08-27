namespace ClassRoomNet60;

public class ClassRoom
{
    public string ClassName { get; set; }
    public List<Student> StudentList { get; set; } = new List<Student>();
    public DateTime SemesterStart { get; set; }

    public ClassRoom()
    {
        
    }
}
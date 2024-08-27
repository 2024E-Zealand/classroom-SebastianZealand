namespace ClassRoomNet60;

public class ClassRoom
{
    public string ClassName { get; set; }
    public List<Student> StudentList { get; set; } = new List<Student>();
    public DateTime SemesterStart { get; set; }

    public ClassRoom()
    {
        
    }

    public override string ToString()
    {
        var text = string.Join(",", StudentList.Where(s => s != null).Select(s => s.Name));
        return
            $"{nameof(ClassName)}: {ClassName}, {nameof(StudentList)}: {text}, {nameof(SemesterStart)}: {SemesterStart}";
    }
}
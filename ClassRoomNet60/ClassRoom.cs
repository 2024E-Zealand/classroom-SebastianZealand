using System.Collections.Generic;
using System.Linq.Expressions;

namespace ClassRoomNet60;

public class ClassRoom
{
    public string ClassName { get; set; }
    public List<Student> StudentList { get; set; } = new List<Student>();
    public DateTime SemesterStart { get; set; }

    public ClassRoom()
    {
        
    }

    public void BirthdaysInSeason() {
       var list = new List<string> {"Summer", "Winter", "Spring","Autumn" };
        
        foreach (var season in list)
        {
            var count = StudentList.Where(s => s.Season() == season).Count();
            Console.WriteLine($"Number of {season} students: " + count);
        }
    }

    public override string ToString()
    {
        var text = string.Join(",", StudentList.Where(s => s != null).Select(s => s.Name));
        return
            $"{nameof(ClassName)}: {ClassName}, {nameof(StudentList)}: {text}, {nameof(SemesterStart)}: {SemesterStart}";
    }
}
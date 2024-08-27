namespace ClassRoomNet60;

public class Student
{
    public string Name { get; set; }
    public int BirthMonth { get; set; }
    public int Birthday { get; set; }

    public Student(string name, int birthMonth, int birthday)
    {
        Name = name;
        BirthMonth = birthMonth;
        Birthday = birthday;
    }
}
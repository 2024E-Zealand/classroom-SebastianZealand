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

    public string Season() {
        
        switch (BirthMonth)
        {
            case 1:
            case 2:
            case 12:
                return "Winter";
            case 3:
            case 4:
            case 5:
                return "Spring";
            case 6:
            case 7:
            case 8:
                return "Summer";
            case 9:
            case 10:
            case 11: 
                return "Autumn";
        }

        return "Not a month!";

    }
}
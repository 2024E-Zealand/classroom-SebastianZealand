﻿using ClassRoomNet60;

class Program
{
    static void Main(string[] args)
    {
        ClassRoom classRoom = new ClassRoom();
        
        classRoom.ClassName = "3Q";
        classRoom.SemesterStart = DateTime.Today;
        
        Student mathias = new Student("Mathias", 8, 11);
        Student sebastian = new Student("Sebastian", 4, 15);
        Student johan = new Student("Johan", 8, 15);
        
        classRoom.StudentList.Add(mathias);
        classRoom.StudentList.Add(sebastian);
        classRoom.StudentList.Add(johan);

        foreach (var s in classRoom.StudentList)
        {
            Console.WriteLine(s.Name);
        }
        
        Console.WriteLine(classRoom);

        Console.WriteLine(mathias.Season());

        classRoom.BirthdaysInSeason();
    }
}

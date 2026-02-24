using System;
using System.Net.Sockets;
using System.Xml.Linq;
ClassroomManager class1 = new ClassroomManager("1반");
class1.AddStudent("홍길동");
class1.AddStudent("김철수");
class1.AddStudent("이영희");
class1.ShowStudents();
Console.WriteLine();

ClassroomManager class2 = new ClassroomManager("2반");
class2.AddStudent("박민수");
class2.AddStudent("정수진");
class2.ShowStudents();
Console.WriteLine();

ClassroomManager.ShowTotalClassrooms();
class ClassroomManager
{
    const int MaxStudents = 5;
    private string[] names;
    private int studentcount = 0;
    readonly string classname;
    public static int totalClassrooms = 0;
    public ClassroomManager(string name)
    {
        classname = name;
        names = new string[MaxStudents];
        totalClassrooms++;
    }
    public void AddStudent(string name)
    {
        if (studentcount > MaxStudents)
        {
            Console.WriteLine("정원이 가득 찼습니다.");
            return;
        }
        names[studentcount] = name;
        studentcount++;
    }

    public void ShowStudents()
    {
        Console.WriteLine($"=== {totalClassrooms}반 학생 목록 ({studentcount}/{MaxStudents}) ===");

        for (int i = 0; i < studentcount; i++)
        {
            Console.WriteLine($"{i + 1}. {names[i]}");
        }
    }

    public static void ShowTotalClassrooms()
    {
        Console.WriteLine($"전체 교실 수: {totalClassrooms}");
    }
}

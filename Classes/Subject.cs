using System.Security.AccessControl;

namespace ConsoleApp1.Classes;

public class Subject
{
    public int subjectCode { get; set; }
    public string name { get; set; }
    public int  totalHours { get; set; }
    public int credit { get; set; }
    public int  semester { get; set; }

    public Subject(int code, string name)
    {
        this.subjectCode = code;
        this.name = name;
    }
    

    public void show()
    {
        Subject subject1 = new Subject(1, "Math");
        Subject subject2 = new Subject(2, "English Lang");
        Subject subject3 = new Subject(3, "Cloud Computing");
    }
}
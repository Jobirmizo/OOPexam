using ConsoleApp1.Classes;


namespace ConsoleApp1.Classes;

public class Program
{
    static void Main(string[] args)
    {
        
        Teacher teacher1 = new Teacher("Temur", "Kuchkarov");
        Teacher teacher2 = new Teacher("Sardor", "Ganiev");
        Subject subject = new Subject(1, "Math");
        Subject subject2 = new Subject(2, "Programming");
        Subject subject3 = new Subject(3, "Cloud Computing");
        Subject subject4 = new Subject(4, "Franch language");
        
        
        teacher1.AddSubjects(subject);
        teacher1.AddSubjects(subject2);
        teacher1.AddSubjects(subject3);
        teacher1.AddSubjects(subject4);

        teacher2.AddSubjects(subject4);
    
        teacher1.checkSubjects();
        teacher2.checkSubjects();
        
        Console.WriteLine($"{teacher1.fname} has: {teacher1.getNumberOfSubjects()}");

    }
}
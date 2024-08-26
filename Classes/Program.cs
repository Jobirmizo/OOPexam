namespace ConsoleApp1.Classes;

public class Program
{
   
    
    static void Main(string[] args)
    {
        Teacher teacher1 = new Teacher("Sardor", "Ganiev");
        Teacher teacher2 = new Teacher("Jo1", "T");
        Subject math = new Subject(17, "Math");
        Subject programming = new Subject(18, "Programming");
        
        teacher1.AddSubjects(math);
        teacher2.AddSubjects(programming);
        
        teacher2.showSubjects(teacher2);
    }
}
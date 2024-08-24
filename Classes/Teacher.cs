namespace ConsoleApp1.Classes;

public class Teacher
{
    public string fname { get; set; }
    public string lname { get; set; }
    public DateTime birthDate { get; set; }
    public string Departament { get; set; }
    private List<Subject> subjects;

    public Teacher(string fname, string lname)
    {
        this.fname = fname;
        this.lname = lname;
    }

    public void teacher()
    {
        subjects = new List<Subject>();
    }
    public void showSubjects()
    {
        
    }

    static void Main()
    {
        Teacher teacher1 = new Teacher("Sardor", "G`aniev");
        Subject subject1 = new Subject(1, "Math");
        Subject subject2 = new Subject(2, "English Lang");
        Subject subject3 = new Subject(3, "Cloud Computing");
        
        
    }
}
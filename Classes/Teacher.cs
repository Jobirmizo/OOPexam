using ConsoleApp1.Classes;

namespace ConsoleApp1.Classes;

public class Teacher
{
    public string fname { get; set; }
    public string lname { get; set; }
    public DateTime birthDate { get; set; }
    public string departament { get; set; }
    public List<Subject> Subjects { get; set; }

    public Teacher(string fname, string lname)
    {
        this.fname = fname;
        this.lname = lname;
        Subjects = new List<Subject>();
    }

    public void AddSubjects(Subject subject)
    {
        Subjects.Add(subject);
    }

   
    public void showSubjects()
    {
        foreach (Subject subject in Subjects)
        {
            Console.WriteLine($"Teacher: {fname} has {subject.name}");
        }
    }

    public int getNumberOfSubjects()
    {
        return Subjects.Count;
    }
    
    public bool checkSubjects()
    {
        if (Subjects.Count > 0)
        {
            Console.WriteLine($"Subjects assigned to {fname}:");
            foreach (var subject in Subjects)
            {
                Console.WriteLine($"- {subject.name} (Code: {subject.subjectCode})");
            }
            return true;
        }
        else
        {
            Console.WriteLine($"{fname} has no subjects assigned.");
            return false;
        }
    }
    
}
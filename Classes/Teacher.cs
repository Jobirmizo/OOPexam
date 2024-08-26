using System.Collections;

namespace ConsoleApp1.Classes;

public class Teacher
{
    public string fname { get; set; }
    public string lname { get; set; }
    public DateTime birthDate { get; set; }
    public string Departament { get; set; }
    public ArrayList Subjects { get; set; }
    
    public Teacher(string fname, string lname)
    {
        this.fname = fname;
        this.lname = lname;
        Subjects = new ArrayList();
    }
    

    public void AddSubjects(Subject subject)
    {
        Subjects.Add(subject);
    }

    public bool HasSubjects()
    {
        return Subjects.Count > 0;
    }
    
    public void showSubjects(Teacher teacher)
    {
        if (HasSubjects())
        {
            Console.WriteLine($"{teacher.fname} teaches the following subjects:");
            foreach (Subject subject in Subjects)
            {
                Console.WriteLine($"Subject code: {subject.subjectCode}, Name: {subject.name}");
            }
        }
        else
        {
            Console.WriteLine($"{teacher.fname} has no any subjects");
        }
    }

    public void getNumberOfSubjects(Subject subject, Teacher teacher)
    {
        
    }

    
    
}
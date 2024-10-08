﻿using ConsoleApp1.Classes;


namespace ConsoleApp1.Classes;

public class Subject
{
    public int subjectCode { get; set; }
    public string name { get; set; }
    public int totalHours { get; set; }
    public int credit { get; set; }
    public int semester { get; set; }

    public Subject(int code, string name)
    {
        this.subjectCode = code;
        this.name = name;
    }

    public void show()
    {
        Console.WriteLine($"Code: {subjectCode}, Name: {name}");
    }
}
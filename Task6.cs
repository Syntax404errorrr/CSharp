using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Grade: {Grade}");
    }

    public bool IsPassed()
    {
        return Grade >= 75;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Student s = new Student();
        s.Name = "Alvin";
        s.Age = 22;
        s.Grade = 90;

        s.DisplayInfo();

        Console.WriteLine("Status: " + (s.IsPassed() ? "Passed" : "Failed"));
    }
}

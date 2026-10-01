using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");

        string task = assignment.GetSummary();
        Console.WriteLine($"{task}\n");

        MathAssignment maths = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string student = maths.GetSummary();
        string mathsHomework = maths.GetHomeworkList(); 
        Console.WriteLine($"{student}\n{mathsHomework}");

        WritingAssignment write = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        string student1 = write.GetSummary();
        string writing = write.GetWritingInformation();
        Console.WriteLine($"\n{student}\n{writing}");
    }
}
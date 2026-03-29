using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Alice Johnson", "Science");
        assignment.GetSummary();

        WritingAssignment writingAssignment = new WritingAssignment("John Doe", "History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());

        MathAssignment mathAssignment = new MathAssignment("Jane Smith", "Algebra", "Section 5.2", "Problems 1-10");
        Console.WriteLine(mathAssignment.GetHomeworkList());



    }

}
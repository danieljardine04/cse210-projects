using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Daniel", "Math");

        Console.WriteLine(assignment.GetSummary());

        MathAssignment homework = new MathAssignment(assignment.GetName(), assignment.GetTopic(), "3", "10-21");
        Console.WriteLine(homework.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment(assignment.GetName(), assignment.GetTopic(), "How Dummies write");
        Console.WriteLine(writing.GetWritingInformation());
    }
}
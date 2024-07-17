using System;

public class Program
{
    public static void Main()
    {
        // Test Assignment
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        // Test MathAssignment
        MathAssignment mathHw = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathHw.GetSummary());
        Console.WriteLine(mathHw.GetHomeworkList());

        // Test WritingAssignment
        WritingAssignment writingHw = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingHw.GetSummary());
        Console.WriteLine(writingHw.GetWritingInformation());
    }
}

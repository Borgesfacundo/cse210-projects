using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("Mark Zuckenbergh", "multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment a2 = new("Roberto Rodriguez", "Fractions", "7.2", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHoemworkList());

        WritingAssignment a3 = new("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}
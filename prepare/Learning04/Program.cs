using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment samuel = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(samuel.GetSummary());

        MathAssignment roberto = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(roberto.GetSummary());
        Console.WriteLine(roberto.GetHomeworkList());

        WritingAssignment mary = new WritingAssignment("Mary Waters", "European History", "The Causes of Ward War II");
        Console.WriteLine(mary.GetSummary());
        Console.WriteLine(mary.GetWritingInformation());
    }
}
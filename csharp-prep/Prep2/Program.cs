using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Please enter your grade percentage: ");
        int gradePercent = int.Parse(Console.ReadLine());
        string gradeLetter;
        bool passed;
        if (gradePercent >= 90) {
            gradeLetter = "A";
            passed = true;
        }
        else if (gradePercent >= 80) {
            gradeLetter = "B";
            passed = true;
        }
        else if (gradePercent >= 70) {
            gradeLetter = "C";
            passed = true;
        }
        else if (gradePercent >= 60) {
            gradeLetter = "D";
            passed = false;
        }
        else {
            gradeLetter = "F";
            passed = false;
        }

        if (passed) {
            Console.WriteLine($"Congratulations! You passed the class with a {gradeLetter}");
        }
        else {
            Console.WriteLine($"Sorry, but you got a {gradeLetter}. You did not pass the class.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool generatingList = true;
        int sum = 0;
        float average = 0;
        int max = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (generatingList) {
            Console.Write("Enter number: ");
            int newNumber = int.Parse(Console.ReadLine());
            if (newNumber == 0) {
                generatingList = false;
            }
            else {
                numbers.Add(newNumber);
                sum += newNumber;
                if (newNumber > max) {
                    max = newNumber;
                }
            }
        }
        average = sum/numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
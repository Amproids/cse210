using System;

class Program
{
    static void Main(string[] args)
    {
        string filename = "Journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string header = parts[0];
            string entry = parts[1];
            Console.WriteLine($"Header: {header}");
            Console.WriteLine($"Entry:  {entry}");
        }
    }
}
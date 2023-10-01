using System;

class Program
{
    static void Main(string[] args)
    {
        string journalFile = "Journal.txt";
        string[] journalLines = System.IO.File.ReadAllLines(journalFile);

        Console.WriteLine("Welcome to the journaling program.");
        bool journaling = true;
        Prompt prompt = new Prompt();

        while (journaling) {
            Console.WriteLine("Choose an option (1-6)");
            Console.WriteLine("1. Make entry for today.");
            Console.WriteLine("2. See all journal entries.");
            Console.WriteLine("3. Exit program.");
            string menuInput = Console.ReadLine();
            if (menuInput == "1") {
                DateTime currentDateTime = DateTime.Now;
                string dateText = currentDateTime.ToShortDateString();
                string newPromptText = prompt.GeneratePrompt();
                Console.WriteLine($"{newPromptText}");
                string newEntryText = Console.ReadLine();

                //Make sure existing entries are re-written to text file.
                foreach (var existingEntry in journalLines) {
                    using (StreamWriter outputFile = new StreamWriter(journalFile)) {
                        outputFile.WriteLine(existingEntry);
                    }
                }
                //Write new entry to text file
                using (StreamWriter outputFile = new StreamWriter(journalFile)) {
                    outputFile.WriteLine($"{dateText},{newPromptText},{newEntryText}");
                }
            }
            else if (menuInput == "2") {
                foreach (var existingEntry in journalLines) {
                    string[] parts = existingEntry.Split(",");
                    string existingDate = parts[0];
                    string existingPrompt = parts[1];
                    string existingResponse = parts[2];
                    Console.WriteLine($"{existingDate}:");
                    Console.WriteLine($"    {existingPrompt}");
                    Console.WriteLine($"    {existingResponse}");
                }
            }
            else if (menuInput == "3") {
                journaling = false;
            }
        }
    }
}

public class Prompt{
    static string _promptOptions = "Prompts.txt";
    string[] _lines = System.IO.File.ReadAllLines(_promptOptions);

    public string GeneratePrompt() {
        Random rnd = new Random();
        int promptSelection = rnd.Next(_lines.Length);
        return _lines[promptSelection];
    }
}
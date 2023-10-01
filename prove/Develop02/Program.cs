using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journaling program.");
        bool journaling = true;
        Prompt prompt = new Prompt();

        while (journaling) {
            Console.WriteLine("Choose an option (1-6)");
            Console.WriteLine("1. Make entry for today.");
            Console.WriteLine("2. Make Entry for specific date.");
            Console.WriteLine("3. See today's journal entry.");
            Console.WriteLine("4. See entry for specific date.");
            Console.WriteLine("5. See all journal entries.");
            Console.WriteLine("6. Exit program.");
            string menuInput = Console.ReadLine();
            if (menuInput == "6") {
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
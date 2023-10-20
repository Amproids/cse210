public class Journal {
    List<Entry> _entries = new List<Entry>{};

    public void AddEntry() {
        string promptText = new PromptGenerator().GetRandomPrompt();
        Console.WriteLine(promptText);
        string entryText = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _entries.Add(new Entry(dateText, promptText, entryText));
    }
    public void DisplayAll() {
        foreach (Entry entry in _entries) {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile (string filename) {
        using (StreamWriter outputFile = new StreamWriter(filename)) {  
            foreach (Entry entry in _entries) {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }
    public void LoadFromFile (string filename) {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines) {
            string[] parts = line.Split(",");
            _entries.Add(new Entry(parts[0], parts[1], parts[2]));
        }
    }
}
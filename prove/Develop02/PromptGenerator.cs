public class PromptGenerator {
    List<string> _prompts = new List<string>{};

    public PromptGenerator() {
        string[] lines = System.IO.File.ReadAllLines("Prompts.txt");
        foreach (string line in lines) {
            _prompts.Add(line);
        }
    }

    public string GetRandomPrompt() {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }
}
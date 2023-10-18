using System.IO;

public class GoalManager {
    private List<object> _goals = new List<object>{};
    private int _score = 0;
    public void Start() {
        bool running = true;
        while (running) {
            string filename = "MyGoals.txt";
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal.");
            Console.WriteLine("  2. List Goals.");
            Console.WriteLine("  3. Save Goals.");
            Console.WriteLine("  4. Load Goals.");
            Console.WriteLine("  5. Record Event.");
            Console.WriteLine("  6. Quit.");
            Console.Write("Select a choice from the menu: ");
            switch (Console.ReadLine()) {
                case "1" :
                    CreateGoal();
                    break;
                case "2" :
                    ListGoalNames();
                    break;
                case "3" :
                    SaveGoals(filename);
                    break;
                case "4" :
                    LoadGoals(filename);
                    break;
                case "5" :
                    RecordEvent();
                    break;
                case "6" :
                    running = false;
                    break;
                default :
                    Console.WriteLine("Invalid Response.");
                    break;
            }
        }

    }

    public void DisplayPlayerInfo() {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames() {
        throw new NotImplementedException();
    }

    public void ListGoalDetails() {
        throw new NotImplementedException();
    }

    public void CreateGoal() {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string newGoalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string newGoalName = Console.ReadLine();
        Console.Write("What is a short Description of it? ");
        string newGoalDesctription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string newGoalPoints = Console.ReadLine();
        switch (newGoalType) {
            case "1" :
                _goals.Add(new SimpleGoal(newGoalName, newGoalDesctription, int.Parse(newGoalPoints), false));
                break;
            case "2" :
                _goals.Add(new EternalGoal(newGoalName, newGoalDesctription, int.Parse(newGoalPoints)));
                break;
            case "3" :
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string newAmountCompleted = Console.ReadLine();
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string newBonus = Console.ReadLine();
                _goals.Add(new ChecklistGoal(newGoalName, newGoalDesctription, int.Parse(newGoalPoints), int.Parse(newAmountCompleted), 0, int.Parse(newBonus)));
                break;
            default :
                Console.WriteLine("Invalid Response.");
                break;
        }
    }

    public void RecordEvent() {
        throw new NotImplementedException();
    }

    public void SaveGoals(string filename) {
        using (StreamWriter outputFile = new StreamWriter(filename)) {
            foreach (Goal goal in _goals) {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename) {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines) {
            string[] parts = line.Split(",");
            if (parts.Length == 4) {
                //It's a simpleGoal
                _goals.Add(new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3])));
            }
            else if (parts.Length == 3) {
                //It's an eternal goal.
                _goals.Add(new EternalGoal(parts[0], parts[1], int.Parse(parts[2])));
            }
            else if (parts.Length == 6) {
                //It's a checklist goal.
                _goals.Add(new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
            } 
        }
    }
}
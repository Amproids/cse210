using System;

class Program
{
    static void Main(string[] args)
    {
        //Setup
        Journal myJournal = new Journal();
        //Menu Loop.
        bool running = true;
        while (running) {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            switch (userInput) {
                case "1" :
                    myJournal.AddEntry();
                    break;
                case "2" :
                    myJournal.DisplayAll();
                    break;
                case "3" :
                    Console.WriteLine("What is the file name?");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;
                case "4" :
                    Console.WriteLine("What is the file name?");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;
                case "5" :
                    running = false;
                    break;
            }
        }
    }
}
using System;

public class Scripture {
    private Reference _scriptureReference;
    private Text _scriptureText;
    private bool _studying = true;

    public Scripture(string scriptureReference, string scriptureText) {
        _scriptureReference = new Reference(scriptureReference);
        _scriptureText = new Text(scriptureText);
    }

    public void StudyScripture() {
        while (_studying) {
            //Console.Clear();
            Console.WriteLine("Do your best to memorize the scripture below.");
            Console.WriteLine();
            Console.Write(_scriptureReference.GetReference());
            Console.WriteLine(_scriptureText.GetText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue, type 'quit' to quit, type 'reset' to start from the beginning.");
            string response = Console.ReadLine();
            if (response == "") {
                _scriptureText.HideRandomWords(3);
            }
            else if (response == "quit") {
                _studying = false;
            }
            else if (response == "reset") {
                _scriptureText.UnhideText();
            }
        }
    }
}
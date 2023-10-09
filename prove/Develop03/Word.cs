using System;

public class Word {

    private string _wordContent;
    private bool _hidden = false;
    private int _length;

    public Word(string wordContent) {
        _wordContent = wordContent;
        _length = wordContent.Length;
    }

    //these Hide and Unhide functions also return boolean values depnding if the function was succesful or not, since the status of the hidden word is unknown to other parts of the program, this allows the program to communicate with other parts.
    public bool HideWord() {
        if (_hidden) {
            return false;
        }
        else {
        _hidden = true;
        return true;
        }
    }
    public bool UnhideWord() {
        if (_hidden) {
            _hidden = false;
            return true;
        }
        else {
            return true;
        }
    }

    public string GetWord() {
        if (_hidden) {
            string underLines = "";
            for (int i = 0; i < _length; i++) {
                if (_wordContent[i] == ',' | _wordContent[i] == '.') {
                    underLines += _wordContent[i];
                }
                else {
                    underLines += "_";
                }
            }
            return underLines;
        }
        else {
            return _wordContent;
        }
    }
}
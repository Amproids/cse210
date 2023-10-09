using System;

public class Text {
    private Word[] _wordArray;
    //with the hiddenWordStatus, index 0 is number of visable words, 1 is hidden words.
    private int _visableWords;

    public Text(string text) {
        string[] tempWordArray = text.Split(" ");
        _wordArray = new Word[tempWordArray.Length];
        for (int i = 0; i < tempWordArray.Length; i++) {
            string word = tempWordArray[i];
            _wordArray[i] = new Word(word);
        }
        _visableWords = _wordArray.Length;
    }

    public string GetText() {
        string textString = "";
        foreach (Word word in _wordArray) {
            textString += word.GetWord() + " ";
        }
        textString.Remove(_wordArray.Length, 1);
        return textString;
    }

    //this function gets one step closer with each succesful HideWord(), and then it cycles and selects a new random word again.
    public void HideRandomWords(int numberOfWords) {
        Console.WriteLine(_visableWords);
        if (_visableWords > 0) {
            if (numberOfWords != 0) {
                Random rnd = new Random();
                int RandomWord  = rnd.Next(0, _wordArray.Length);
                if (_wordArray[RandomWord].HideWord()) {
                    _visableWords -= 1;
                    HideRandomWords (numberOfWords - 1);
                }
                else {
                    HideRandomWords(numberOfWords);
                }
            }
        }
    }
    public void UnhideText() {
        for (int i = 0; i < _wordArray.Length; i ++) {
            if (_wordArray[i].UnhideWord()) {
                _visableWords += 1;
            };
        }
    }
}
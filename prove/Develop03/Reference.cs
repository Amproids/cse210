using System;

public class Reference {
    private string _verseReference;

    public Reference(string verseReference) {
        _verseReference = verseReference;
    }
    public string GetReference() {
        return _verseReference;
    }
}
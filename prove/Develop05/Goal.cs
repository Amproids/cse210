public abstract class Goal {
    protected string _shortname;
    protected string _description;
    protected int _points;

    public Goal(string shortname, string description, int points) {
        _shortname = shortname;
        _description = description;
        _points = points;
    }
    public string GetName() {
        return _shortname;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString() {
        return $"{_shortname} ({_description})";
    }
    public abstract string GetStringRepresentation();
}
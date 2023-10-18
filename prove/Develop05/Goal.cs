public abstract class Goal {
    protected string _shortname;
    protected string _description;
    protected int _points;

    public Goal(string shortname, string description, int points) {
        _shortname = shortname;
        _description = description;
        _points = points;
    }
 
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString() {
        throw new NotImplementedException();
    }
    public abstract string GetStringRepresentation();
}
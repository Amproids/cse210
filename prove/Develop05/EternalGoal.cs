public class EternalGoal : Goal {
    public EternalGoal (string shortname, string description, int points) : base(shortname, description, points) {
        _shortname = shortname;
        _description = description;
        _points = points;
    }

    public override int RecordEvent() {
        return _points;
    }
    public override bool IsComplete() {
        return false;
    }
    public override string GetStringRepresentation() {
        return $"{_shortname},{_description},{_points}";
    }
}
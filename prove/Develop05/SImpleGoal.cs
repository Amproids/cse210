public class SimpleGoal : Goal {
    private bool _isComplete;
    public SimpleGoal(string shortname, string description, int points, bool isComplete) : base(shortname, description, points) {
        _shortname = shortname;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override void RecordEvent() {
        throw new NotImplementedException();
    }
    public override bool IsComplete() {
        return _isComplete;
    }
    public override string GetStringRepresentation() {
        return $"{_shortname},{_description},{_points},{_isComplete}";
    }
}
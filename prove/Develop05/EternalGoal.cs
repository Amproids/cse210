public class EternalGoal : Goal {
    EternalGoal (string shortname, string description, int points) : base(shortname, description, points) {
        _shortname = shortname;
        _description = description;
        _points = points;
    }

    public override void RecordEvent() {
        throw new NotImplementedException();
    }
    public override bool IsComplete() {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation() {
        throw new NotImplementedException();
    }
}
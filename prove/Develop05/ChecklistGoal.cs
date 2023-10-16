public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    ChecklistGoal (string shortname, string description, int points, int target, int bonus) : base(shortname, description, points) {
        _shortname = shortname;
        _description = description;
        _points = points;
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent() {
        throw new NotImplementedException();
    }
    public override bool IsComplete() {
        throw new NotImplementedException();
    }
    public override string GetDetailsString() {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation() {
        throw new NotImplementedException();
    }
}
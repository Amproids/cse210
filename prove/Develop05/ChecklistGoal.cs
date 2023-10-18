public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal (string shortname, string description, int points, int amountCompleted, int target, int bonus) : base(shortname, description, points) {
        _shortname = shortname;
        _description = description;
        _points = points;
        _amountCompleted = amountCompleted;
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
        return $"{_shortname},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}
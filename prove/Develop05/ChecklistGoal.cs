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
    public override int RecordEvent() {
        _amountCompleted += 1;
        if (_amountCompleted == _target) {
            return _points = _bonus;
        }
        else {
            return _points;
        }
    }
    public override bool IsComplete() {
        if (_amountCompleted == _target) {
            return true;
        }
        else {
            return false;
        }
    }
    public override string GetDetailsString() {
        return $"{_shortname} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation() {
        return $"{_shortname},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}
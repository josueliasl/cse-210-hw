// SimpleGoal.cs
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isCompleted = false)
        : base(name, description, points)
    {
        _isComplete = isCompleted;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() 
    { 
        return _isComplete;
    }
    public override string DisplayString() 
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} ({_description})";
    }

    public override string GetStringRepresentation()
    { 
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }
}


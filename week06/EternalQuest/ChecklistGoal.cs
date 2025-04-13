public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            return _amountCompleted == _target ? _points + _bonus : _points;
        }
        return 0;
    }

    public override bool IsComplete() 
    { 
        return _amountCompleted >= _target;
    }    

    public override string DisplayString()
    { 
        return $"[{(_amountCompleted >= _target ? "X" : " ")}] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    { 
        return $"CheckListGoal:{_name},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
    public override int GetPoints() 
    { 
        return _points;
    }    
    public override int GetBonus()
    { 
        return _bonus;
    }    
}





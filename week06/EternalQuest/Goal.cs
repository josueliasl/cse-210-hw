// Goal.cs
using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public abstract string DisplayString();
    public virtual int GetPoints() => _points;
    public virtual int GetBonus() => 0;

    public static Goal FromString(string line)
    {
        string[] parts = line.Split(':');
        string type = parts[0];
        string[] data = parts[1].Split(',');

        return type switch
        {
            "SimpleGoal" => new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])),
            "EternalGoal" => new EternalGoal(data[0], data[1], int.Parse(data[2])),
            "CheckListGoal" => new CheckListGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5])),
            _ => throw new Exception("Unknown goal type: " + type),
        };
    }
}


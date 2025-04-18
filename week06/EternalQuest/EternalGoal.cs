using System.ComponentModel;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string IsComplete()
    {
        return " ";
    }

    public override string GetDetailsString()
    {
        return ($"{_shortName} {_points}");
    }
    public override string GetStringRepresentation()
    {
        string representation = ($"EternalGoal:{_shortName}|{_description}|{_points}");
        return representation;
    }
}
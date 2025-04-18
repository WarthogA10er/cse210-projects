public class StopHabit:Goal
{
    
    public StopHabit(string name, string description, int points) : base(name, description, points)
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
        string representation = ($"StopHabit:{_shortName}|{_description}|{_points}");
        return representation;
    }
}

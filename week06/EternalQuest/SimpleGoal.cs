public class SimpleGoal:Goal
{
    public SimpleGoal(string name, string description, int points):base(name, description, points)
    {

    }

    public SimpleGoal(string isComplete, string shortName, string description, int points) : base(shortName, description, points)
    {
        if(isComplete == " ")
        {
            _isComplete = false;
        }

        else if(isComplete == "X")
        {
            _isComplete = true;
        }
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override string GetDetailsString()
    {
        return ($"[{IsComplete()}] {_shortName} {_points}");
    }

    public override string GetStringRepresentation()
    {
        string representation = ($"SimpleGoal:{IsComplete()}|{_shortName}|{_description}|{_points}");
        return representation;
    }
}
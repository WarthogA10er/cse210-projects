public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    protected Goal(string name, string description, int points)
    {
        _isComplete = false;
        _shortName = name;
        _description = description;
        _points = points;
    }
    
    public string GetName()
    {
        return _shortName;
    }
    public abstract int RecordEvent();

    public virtual string IsComplete()
    {
        string completion = " ";
        if(_isComplete == true)
        {
            completion = "X";
        }
        return completion;
    }

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();
}

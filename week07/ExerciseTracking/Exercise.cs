public abstract class Exercise
{
    protected string _type;
    protected DateTime _date;
    protected int _lengthInMinutes;

    protected Exercise(int lengthInMinutes)
    {
        _date = DateTime.Today;
        _lengthInMinutes = lengthInMinutes;
    }
    
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public string GetSummary()
    {
        string formattedDate = _date.ToString("dd MMM yyyy");
        string summary = ($"{formattedDate} {_type}({_lengthInMinutes}) - Distance {GetDistance()}, Speed {GetSpeed()}, Pace: {GetPace()} minute per mile.");
        return summary;
    }
}
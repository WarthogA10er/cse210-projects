
using System.ComponentModel.DataAnnotations;

public class Cycling:Exercise
{
    private float _speed;

    public Cycling(float speed, int lengthInMinutes):base(lengthInMinutes)
    {
        _type = "Cycling";
        _speed = speed;
    }

    public override float GetDistance()
    {
        float lengthInHours = _lengthInMinutes / 60;
        float distance = _speed * lengthInHours;
        float rounded = (float)Math.Round(distance, 2);
        return rounded;
    }
    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetPace()
    {
        float pace = 60 / _speed;
        float rounded = (float)Math.Round(pace, 2);
        return rounded;
    }
}
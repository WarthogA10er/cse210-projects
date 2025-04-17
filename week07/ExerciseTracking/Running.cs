public class Running:Exercise
{
    private float _distance;

    public Running(float distance, int lengthInMinutes) : base(lengthInMinutes)
    {
        _type = "Running";
        _distance = distance;
    }

     public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        float speed = (_distance / _lengthInMinutes) * 60;
        float rounded = (float)Math.Round(speed, 2);
        return rounded;
   }
    public override float GetPace()
    {
        float pace = 60 / GetSpeed();
        float rounded = (float)Math.Round(pace, 2);
        return rounded;
    }
}
public class Swimming:Exercise
{
    private int _laps;

    public Swimming(int laps, int lengthInMinutes):base(lengthInMinutes)
    {
        _type = "Swimming";
        _laps = laps;
    }

     public override float GetDistance()
    {
        double distance = ((_laps * 50) / 1000) * 0.62;
        float rounded = (float)Math.Round(distance, 2);
        return rounded;
    }
    public override float GetSpeed()
    {
        float speed = (GetDistance() / _lengthInMinutes) * 60;
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
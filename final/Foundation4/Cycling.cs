public class Cycling : Activity
{
    private double _speed;
    
    public Cycling(string date, double speed, int time) : base(date, "Cycling", time)
    {
        _speed = speed;
    }
    protected override double GetDistance()
    {
        return (_speed / 60.0) * GetTimeInMinutes();
    }
    protected override double GetSpeed()
    {
        return _speed;
    }
    protected override double GetPace()
    {
        return GetTimeInMinutes() / GetDistance();
    }
}
public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, int numberOfLaps, int time) : base(date, "Swimming", time)
    {
        _numberOfLaps = numberOfLaps;
    }

    protected override double GetDistance()
    {
        return (_numberOfLaps * 50.0) / 1000* 0.62 ;
    }
    protected override double GetSpeed()
    {
        return (GetDistance() / GetTimeInMinutes()) * 60.0;
    }
    protected override double GetPace()
    {
        return GetTimeInMinutes() / GetDistance();
    }
}
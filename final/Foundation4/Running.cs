class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(double distance, string date, double length) : base(date, length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {

        return _distance * GetLength();
    }
}
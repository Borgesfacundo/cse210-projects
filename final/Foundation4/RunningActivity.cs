class RunningActivity : Activity
{
    private double _distance;

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {

        return _distance * GetLength();
    }
}
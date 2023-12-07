class Running : Activity
{
    private float _distance;

    public Running(float distance, string date, float length) : base(date, length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
}
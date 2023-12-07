
class Swimming : Activity
{
  private int _lapLength = 50;
  private double _laps;

  public Swimming(double laps, string date, double length) : base(date, length)
  {
    _laps = laps;
  }

  public override double GetDistance()
  {
    return _laps * _lapLength / 1000;
  }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}
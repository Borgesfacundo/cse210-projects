class Cycling : Activity
{
  private double _speed;

  public Cycling(double speed, string date, double length) : base(date, length)
  {
    _speed = speed;
  }

  public override double GetDistance()
  {
    return _speed * GetLength() / 60;
  }
  public override double GetSpeed()
  {
    return _speed;
  }
}
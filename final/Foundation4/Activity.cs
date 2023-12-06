abstract class Activity
{
    private string _date;
    private double _length;
    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();

    public virtual double GetSpeed()
    {
        return 60 * GetPace();
    }

    public virtual double GetPace()
    {
        return 60 * GetSpeed();
    }

    public string GetDate()
    {
        return _date;
    }
    public double GetLength()
    {
        return _length;
    }

    public string GetSummary()
    {
        return $"{GetDate()} {this.GetType().Name} ({GetLength()}min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

}
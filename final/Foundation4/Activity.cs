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
        return GetDistance() / GetLength() * 60;
    }

    public virtual double GetPace()
    {
        return 60 / GetSpeed();
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
        return $"{GetDate()} {this.GetType().Name} ({GetLength()} min)- Distance {GetDistance():0.0} kilometers, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per kilometer";
    }

}
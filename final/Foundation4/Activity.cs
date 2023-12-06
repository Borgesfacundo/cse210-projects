abstract class Activity
{
    private string _date;
    private double _length;

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

}
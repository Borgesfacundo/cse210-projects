abstract class Goal
{
    private string _name;
    protected string _description;
    protected int _points;


    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    // Aca tengo que pasar la infor guardada en txt?
    public Goal(string savedString)
    {

        string[] parts = savedString.Split(",");

        string typeOfGoal = parts[0];
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);

    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

    public virtual int RecordEvent()
    {
        return _points;
    }

    public virtual string ToSavedString()
    {
        return $"{this.GetType().Name}, {GetName()}, {_description}, {_points}";
    }

    public virtual string ToString()
    {
        return $"[ ] {GetName()} ({_description})";
    }

}
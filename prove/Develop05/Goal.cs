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

    public abstract string ToSavedString();

    public abstract string ToString();

}
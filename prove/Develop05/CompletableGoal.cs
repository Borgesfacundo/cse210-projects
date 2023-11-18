abstract class CompletableGoal : Goal
{
    protected bool isCompleted;

    protected CompletableGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    protected CompletableGoal(string savedString) : base(savedString)
    {
        string[] parts = savedString.Split(",");
        string typeOfGoal = parts[0];
        SetName(parts[1]);
        _description = parts[2];
        _points = int.Parse(parts[3]);
        if (parts[4] == "true")
        {
            isCompleted = true;
        }
        else
        {
            isCompleted = false;
        }
    }
    public override string ToSavedString()
    {
        return $"{this.GetType().Name}, {GetName()}, {_description}, {_points}, {isCompleted}";
    }
    public override string ToString()
    {
        if (isCompleted == true)
        {
            return $"[X] {GetName()} ({_description})";
        }
        else
        {
            return $"[ ] {GetName()} ({_description})";
        }
    }
}
class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public EternalGoal(string savedString) : base(savedString)
    {
        string[] parts = savedString.Split(",");
        string typeOfGoal = parts[0];
        SetName(parts[1]);
        _description = parts[2];
        _points = int.Parse(parts[3]);
    }
}

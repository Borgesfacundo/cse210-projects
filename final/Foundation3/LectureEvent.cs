using System.Text;

class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string speaker, int capacity, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetFullDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{FullDetails()}");
        sb.AppendLine($"Event type: {this.GetType().Name}");
        sb.AppendLine($"Speaker: {_speaker}");
        sb.AppendLine($"Capacity: {_capacity}");
        return sb.ToString();
    }
}
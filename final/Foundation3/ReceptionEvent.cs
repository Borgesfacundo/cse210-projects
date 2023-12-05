using System.Text;

class ReceptionEvent : Event
{
    string _email;
    public ReceptionEvent(string email, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _email = email;
    }
    public string GetFullDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{FullDetails()}");
        sb.AppendLine($"Event type: {this.GetType().Name}");
        sb.AppendLine($"Email: {_email}");
        return sb.ToString();
    }
}
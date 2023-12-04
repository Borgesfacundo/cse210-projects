using System.Text;

class Event
{
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address a1;

    public Event(string type, string title, string description, string date, string time, Address address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }

    public string StandardDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Title: {_title}");
        sb.AppendLine($"Description: {_description}");
        sb.AppendLine($"Date: {_date}");
        sb.AppendLine($"Time: {_time}");
        sb.AppendLine($"Address: {a1.ToString()}");

        return sb.ToString();
    }

}
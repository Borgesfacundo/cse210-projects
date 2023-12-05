using System.Text;

class OutdoorGatheringEvent : Event
{
    private string _weatherForecast;

    public OutdoorGatheringEvent(string weatherForecast, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetFullDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{FullDetails()}");
        sb.AppendLine($"Event type: {this.GetType().Name}");
        sb.AppendLine($"Weather Forecast: {_weatherForecast}");
        return sb.ToString();
    }
}
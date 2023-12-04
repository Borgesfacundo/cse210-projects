class Address
{
    private string _city;
    private string _street;
    private string _state;
    private string _country;

    public Address(string city, string street, string state, string country)
    {
        _city = city;
        _street = street;
        _state = state;
        _country = country;
    }
    public bool IsUSA()
    {
        return _country.ToUpper() == "USA";
    }
    public string ProductAddress()
    {
        return $"{_city}, {_street}, {_state}, {_country}";
    }
}
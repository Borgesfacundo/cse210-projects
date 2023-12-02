class Address
{
    private string _street;
    private string _state;
    private string _country;
    private bool isUSA = false;

    public Address(string street, string state, string country)
    {
        _street = street;
        _state = state;
        _country = country;
    }
    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return isUSA = true;
        }
        else 
        {
            return isUSA = false;
        }
    }
    public string ProductAddress()
    {
        return $"{_street}, {_state}, {_country}";
    }
}
class Customer 
{
    private string _customerName;
    private Address address;

    public Customer(string customerName, Address address1)
    {
        _customerName = customerName;
        address = address1;
    }

    public string ToString()
    {
        return $"{_customerName} - {address.ProductAddress()}";
    }
    public bool LivesInUSA()
    {
        return address.IsUSA();
    }

}
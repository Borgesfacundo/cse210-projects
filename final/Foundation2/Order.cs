class Order 
{
    private List<Product> products = new List<Product>();
    private Customer customer;
    private double totalCost;
    private Address address;

    public Order(Customer c1, Address a1)
    {
        customer = c1;
        address = a1;
    }

    public void PackingLabel()
    {
        foreach(Product p1 in products)
        {
            Console.WriteLine($"{p1.Name()}-{p1.Id()}");
        }

    }

    public string ShippingLabel()
    {
        return $"{customer.CustomerName()} - {address.ProductAddress()}";
    }

    public double TotalPrice()
    {
        foreach (Product p in products)
        {
            totalCost += p.Price();
        }
        if (customer.LivesInUSA())
        {
            totalCost += 5;
        }
        else 
        {
            totalCost += 35;
        }

        return totalCost;
    }
}
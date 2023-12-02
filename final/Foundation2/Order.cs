class Order 
{
    private List<Product> products = new List<Product>();
    private Customer customer;
    private double totalCost;
    private Address address;
    private string packingLabel;

    public Order(Customer c1, Address a1)
    {
        customer = c1;
        address = a1;
    }

    public string PackingLabel()
    {
        foreach(Product p1 in products)
        {
            packingLabel += $"{p1.Name()} - {p1.Id()}\n";
        }
        return packingLabel;
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
    public List<Product> AddToList(Product product)
    {
        products.Add(product);
        return products;
    }
    public List<Product> ToStringList()
    {
       return products;
    }
}
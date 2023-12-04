class Order 
{
    private List<Product> products = new List<Product>();
    private Customer customer;
    public Order(Customer c1)
    {
        customer = c1;
    }

    public string PackingLabel()
    {
        string packingLabel = "";
        foreach(Product p1 in products)
        {
            packingLabel += $"{p1.NameAndId()}\n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        return $"{customer.ToString()}";
    }

    public double TotalPrice()
    {
        double totalCost = 0;
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
}
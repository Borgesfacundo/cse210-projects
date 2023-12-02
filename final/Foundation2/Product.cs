class Product
{
    private string productName;
    private string productId;
    private double productPrice;
    private int productQuantity;

    public Product(string name, string id, double price, int quantity)
    {
        productName = name;
        productId = id;
        productPrice = price;
        productQuantity = quantity;
    }

    public string Name()
    {
        return productName;
    }
    public string Id()
    {
        return productId;
    }
    public double Price()
    {
        return productPrice * productQuantity;
    }
    public int Quantity()
    {
        return productQuantity;
    }

}
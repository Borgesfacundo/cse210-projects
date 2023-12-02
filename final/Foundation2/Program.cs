using System;

class Program
{
    static void Main(string[] args)
    {
        //First Order
        Address address1 = new Address("Dornock Dr", "Utah", "USA");
        Product product1 = new Product("Jacket", "454712", 25, 1);
        Product product2 = new Product("T-shirt", "487564", 20, 3);
        Product product3 = new Product("Buzz Light Year", "745869", 17.50, 1);
        Customer customer1 = new Customer("Brondon Rea", address1);
        Order order1 = new Order(customer1, address1);
        order1.AddToList(product1);
        order1.AddToList(product2);
        order1.AddToList(product3);

        //Printing information
        Console.WriteLine($"Packing Label:\n{order1.PackingLabel()}");

        Console.WriteLine($"Shipping Label:\n{order1.ShippingLabel()}\n");

        Console.WriteLine($"Total price:\n{order1.TotalPrice()}\n");

        //Second Order
        Address address2 = new Address("Heredia", "Buenos Aires", "Argentina");
        Product product4 = new Product("Power Ranger", "254785", 50, 4);
        Product product5 = new Product("PS5", "101454", 500, 1);
        Product product6 = new Product("Lego", "147852", 369.99, 1);
        Customer customer2 = new Customer("John Wick", address2);
        Order order2 = new Order(customer2, address2);
        order2.AddToList(product4);
        order2.AddToList(product5);
        order2.AddToList(product6);

        //Printing information
        Console.WriteLine($"Packing Label:\n{order2.PackingLabel()}");

        Console.WriteLine($"Shipping Label:\n{order2.ShippingLabel()}\n");

        Console.WriteLine($"Total price:\n{order2.TotalPrice()}\n");

    }
}
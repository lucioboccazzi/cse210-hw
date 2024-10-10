using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Address customer1Address = new Address("1234 Elm Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", customer1Address);

        Order order1 = new Order(customer1);

        Product product1a = new Product("Laptop", 101, 1200.00m, 1);
        Product product1b = new Product("Phone", 102, 800.00m, 2);
        order1.AddProduct(product1a);
        order1.AddProduct(product1b);

        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price of Order 1: ${order1.TotalCost()}\n");

        Address customer2Address = new Address("5678 Oak Avenue", "Los Angeles", "CA", "Canada");
        Customer customer2 = new Customer("Jane Smith", customer2Address);

        Order order2 = new Order(customer2);

        Product product2a = new Product("Tablet", 201, 500.00m, 3);
        Product product2b = new Product("Headphones", 202, 150.00m, 1);
        Product product2c = new Product("Smartwatch", 203, 250.00m, 1);
        order2.AddProduct(product2a);
        order2.AddProduct(product2b);
        order2.AddProduct(product2c);

        Console.WriteLine("Order 2 Details:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price of Order 2: ${order2.TotalCost()}\n");
    }
}
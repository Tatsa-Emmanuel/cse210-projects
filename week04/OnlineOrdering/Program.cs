using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer
        Address address1 = new Address("123 Maple Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        
        order1.AddProduct(new Product("Wireless Mouse", "M-101", 25.99, 2));
        order1.AddProduct(new Product("Mousepad", "MP-202", 9.50, 1));

        // Order 2: International Customer
        Address address2 = new Address("456 Oak Avenue", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        
        order2.AddProduct(new Product("Mechanical Keyboard", "K-303", 89.99, 1));
        order2.AddProduct(new Product("USB-C Hub", "U-404", 35.00, 1));
        order2.AddProduct(new Product("Monitor Stand", "S-505", 45.00, 2));

        // Display Results for Order 1
        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost():0.00}");
        Console.WriteLine("\n");

        // Display Results for Order 2
        Console.WriteLine("=== ORDER 2 ===");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost():0.00}");
    }
}
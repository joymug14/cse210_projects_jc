using System;

class Program
{
    static void Main(string[] args)
    {
        // Order1 international customer
        Address address1 = new Address("1045 Gwaze St", "Chitungwiza", "Harare", "Zimbabwe");
        Customer customer1 = new Customer("Bubbly Changu", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Water pump", "SPOO1", 70.00, 3));
        order1.AddProduct(new Product("Diagnostic Machine", "DM-345", 789.00, 1));
        order1.AddProduct(new Product("Keyboard", "KBD-223", 50.00, 1));

        // Order2 USA customer
        Address address2 = new Address("115 Sixth St", "Fresno", "CA", "USA");
        Customer customer2 = new Customer("Best Chann", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "MN-OO1", 200.00, 2));
        order2.AddProduct(new Product("Mouse", "MSE-310", 25.00, 1));
        order2.AddProduct(new Product("Keyboard", "KBD-223", 50.00, 1));

        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine(order1.GetPackagingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");
        
        Console.WriteLine("=== ORDER 2 ===");
        Console.WriteLine(order2.GetPackagingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}\n");
        

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Order order = new Order(
            new Customer("John Doe", new Address("123 Main St", "Anytown", "CA", "USA")),
            new List<Product>
            {
                new Product("Widget", "W123", 19.99, 2),
                new Product("Gadget", "G456", 29.99, 1)
            }
        );
        Console.WriteLine("-----------------------------");
        Console.WriteLine(order.displayOrderDetails());
        Console.WriteLine("-----------------------------");
        Console.WriteLine(order.getPackingLabel());
        Console.WriteLine("-----------------------------");
        Console.WriteLine(order.getShippingLabel());
        Console.WriteLine("-----------------------------");


        Order order1 = new Order(
            new Customer("Jane Smith", new Address("456 Elm St", "Othertown", "ON", "Canada")),
            new List<Product>
            {
                new Product("Thingamajig", "T789", 9.99, 5),
                new Product("Doohickey", "D012", 14.99, 3)
            }
        );
        Console.WriteLine("-----------------------------");
        Console.WriteLine(order1.displayOrderDetails());
        Console.WriteLine("-----------------------------");
        Console.WriteLine(order1.getPackingLabel());
        Console.WriteLine("-----------------------------");
        Console.WriteLine(order1.getShippingLabel());
        Console.WriteLine("-----------------------------");


    }
}
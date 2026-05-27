using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("ORDER 1:\n");
        Address address1 = new Address("656", "Almost Hell", "Texas", "USA");
        Customer customer1 = new Customer("Kevin the Imp", address1);
        Product p1 = new Product("Suffering", 8520, 49.98, 2);
        Product p2 = new Product("Flames of Torment", 6541, 132.99, 1);
        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        Console.WriteLine("PACKING LABEL: ");
        order1.DisplayPackingLabel();

        Console.WriteLine("\nSHIPPING LABEL: ");
        order1.DisplayShippingLabel();

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");
        Console.WriteLine(new string('-', 40));

        Console.WriteLine("ORDER 2: \n");
        Address address2 = new Address("1234 Numerical Str.", "Flat Butte", "Nebrasska", "USA");
        Customer customer2 = new Customer("Immature Charlie", address2);
        Product p3 = new Product("Whoopie Cushion", 9009, 7.99, 100);
        Product p4 = new Product("Glitter - 1 Pound", 59009, 8.99, 50);
        Product p5 = new Product("Video Cameras", 6969, 1299.99, 1);
        Order order2 = new Order(customer2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);
        order2.AddProduct(p5);

        Console.WriteLine("PACKING LABEL: ");
        order2.DisplayPackingLabel();

        Console.WriteLine("\nSHIPPING LABEL: ");
        order2.DisplayShippingLabel();
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine(new string('-', 40));
    }
}
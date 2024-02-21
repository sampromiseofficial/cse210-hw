using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating addresses
        Address address1 = new Address("567 Main St", "Anytown", "LAGOS", "NIGERIA");
        Address address2 = new Address("789 Alq St", "Othertown", "ABUJA", "NIGERIA");

        // Creating customers
        Customer customer1 = new Customer("Samson Stephen", address1);
        Customer customer2 = new Customer("John Tina", address2);

        // Creating products
        Product product1 = new Product("Product A", "A567", 10.99, 2);
        Product product2 = new Product("Product B", "B789", 5.49, 3);
        Product product3 = new Product("Product C", "C678", 8.79, 1);

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Displaying order information
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
    }
}
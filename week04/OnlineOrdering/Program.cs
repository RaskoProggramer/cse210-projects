using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "New York",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Smith",
            address1
        );

        Product product1 = new Product(
            "Laptop",
            "P001",
            1000,
            1
        );

        Product product2 = new Product(
            "Mouse",
            "P002",
            25,
            2
        );

        Product product3 = new Product(
            "Keyboard",
            "P003",
            50,
            1
        );

        Order order1 = new Order(customer1, new List<Product>());

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address(
            "45 Nelson Mandela Road",
            "Johannesburg",
            "Gauteng",
            "South Africa"
        );

        Customer customer2 = new Customer(
            "Mpho Rakgope",
            address2
        );

        Product product4 = new Product(
            "Monitor",
            "P004",
            300,
            1
        );

        Product product5 = new Product(
            "Headphones",
            "P005",
            80,
            2
        );

        Order order2 = new Order(customer2, new List<Product>());

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Address address3 = new Address(
            "123 Main Street",
            "New York",
            "New York",
            "USA"
        );

        Customer customer3 = new Customer(
            "John Smith",
            address1
        );

        Product product6 = new Product(
            "Hard Driver",
            "P001",
            500,
            1
        );

        Product product7 = new Product(
            "Mother Board",
            "P003",
            100,
            1
        );

        Order order3 = new Order(customer1, new List<Product>());

        order3.AddProduct(product6);
        order3.AddProduct(product7);
        

        List<Order> orders = new List<Order>();

        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);

        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"           ORDER {orderNumber}");
            Console.WriteLine("=================================");

            // Packing label
            Console.WriteLine("\nPACKING LABEL");
            Console.WriteLine("-------------------------");
            order.Packaging();

            // Shipping label
            Console.WriteLine("\nSHIPPING LABEL");
            Console.WriteLine("-------------------------");
            order.Shipping();

            // Total price
            Console.WriteLine($"\nTOTAL PRICE: ${order.Total():F2}");

            Console.WriteLine();

            orderNumber++;
        }
    }
}
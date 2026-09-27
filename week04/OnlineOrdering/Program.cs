using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // =========================
        // ORDER 1
        // =========================

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


        // =========================
        // ORDER 2
        // =========================

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


        // =========================
        // LIST OF ORDERS
        // =========================

        List<Order> orders = new List<Order>();

        orders.Add(order1);
        orders.Add(order2);


        // =========================
        // DISPLAY ALL ORDERS
        // =========================

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
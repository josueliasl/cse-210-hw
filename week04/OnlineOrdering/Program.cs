using System;

class Program
{
    static void Main()
    {
    Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
    Address address2 = new Address("456 Oak Dr", "New York", "NY", "USA");
    Address address3 = new Address("789 Pine Ln", "Houston", "TX", "USA");
    Address address4 = new Address("321 Maple Ave", "Miami", "FL", "USA");
    Address address5 = new Address("Av. Reforma 100", "Ciudad de México", "CDMX", "México");
    Address address6 = new Address("Calle Juárez 50", "Guadalajara", "Jalisco", "México");

    Customer customer1 = new Customer("John Doe", address1);
    Customer customer2 = new Customer("Jane Smith", address2);
    Customer customer3 = new Customer("Sariah Palmer", address3);
    Customer customer4 = new Customer("Carson Woodward", address4);
    Customer customer5 = new Customer("Josue Leyva", address5);
    Customer customer6 = new Customer("Pancho Villa", address6);

    Product product1 = new Product("Laptop", "POO1", 1000, 2);
    Product product2 = new Product("Mouse", "P002", 25, 1);
    Product product3 = new Product("Smartphone", "PHN456", 500, 2);

    Order order1 = new Order(customer1);
    Order order2 = new Order(customer2);
    Order order3 = new Order(customer3);
    Order order4 = new Order(customer4);
    Order order5 = new Order(customer5);
    Order order6 = new Order(customer6);

    order1.AddProduct(product1);
    order1.AddProduct(product3);
    order2.AddProduct(product2);
    order2.AddProduct(product1);
    order3.AddProduct(product3);
    order3.AddProduct(product2);
    order4.AddProduct(product1);
    order4.AddProduct(product2);
    order5.AddProduct(product3);
    order5.AddProduct(product1);
    order6.AddProduct(product2);
    order6.AddProduct(product2);
    
    Console.WriteLine("Order 1 Total Cost" + " " + order1.GetTotalCost());
    Console.WriteLine("Order 1 Packing Label" + order1.GetPackingLabel());
    Console.WriteLine("Order 1 Shipping Label" + order1.GetShippingLabel());
    Console.WriteLine();
    Console.WriteLine("Order 2 Total Cost" + " " + order2.GetTotalCost());
    Console.WriteLine("Order 2 Packing Label" + order2.GetPackingLabel());
    Console.WriteLine("Order 2 Shipping Label" + order2.GetShippingLabel());
    Console.WriteLine();
    Console.WriteLine("Order 3 Total Cost" + " " + order3.GetTotalCost());
    Console.WriteLine("Order 3 Packing Label" + order3.GetPackingLabel());
    Console.WriteLine("Order 3 Shipping Label" + order3.GetShippingLabel());
    Console.WriteLine();
    Console.WriteLine("Order 4 Total Cost" + " " + order4.GetTotalCost());
    Console.WriteLine("Order 4 Packing Label" + order4.GetPackingLabel());
    Console.WriteLine("Order 4 Shipping Label" + order4.GetShippingLabel());
    Console.WriteLine();
    Console.WriteLine("Order 5 Total Cost" + " " + order5.GetTotalCost());
    Console.WriteLine("Order 5 Packing Label" + order5.GetPackingLabel());
    Console.WriteLine("Order 5 Shipping Label" + order5.GetShippingLabel());
    Console.WriteLine();
    Console.WriteLine("Order 6 Total Cost" + " " + order6.GetTotalCost());
    Console.WriteLine("Order 6 Packing Label" + order6.GetPackingLabel());
    Console.WriteLine("Order 6 Shipping Label" + order6.GetShippingLabel());
    }
}
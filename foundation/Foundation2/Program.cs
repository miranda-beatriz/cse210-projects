using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("2104 Maple Street ", "Mystic Falls", "GE", "USA");
        Address adress2 = new Address("Antonio Marques de Oliveira", "Mogi das Cruzes", "SP", "Brazil");

        Customer customer1 = new Customer("Jeremy Gilbert", address1);
        Customer customer2 = new Customer("Elisangela Miranda", adress2);

        Product product1 = new Product("Laptop", "LAP123", 999.99m, 1);
        Product product2 = new Product("Headphone", "HEA678", 14.50m, 2);
        Product product3 = new Product("Mouse", "MOU624", 25.50m, 3);
        Product product4 = new Product("Monitor", "MON357", 199.99m, 4);
        Product product5 = new Product("Keyboard", "KBD127", 45.99m, 5);

        Order order1 = new Order(new List<Product> { product1, product3, product5 }, customer1);
        Order order2 = new Order(new List<Product> { product2, product4 }, customer2);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\n Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}
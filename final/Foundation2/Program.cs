using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product(1, "tri suit", 89.12, 1);
        Product product2 = new Product(2, "Running Shoes", 52.99, 2);
        Product product3 = new Product(3, "Bike", 300.00, 1);
        Product product4 = new Product(4, "Stop Watch", 12.48, 3);
        Product product5 = new Product(5, "Wet Suit", 69.99, 1);
        Address address1 = new Address("81 Nottingham dr.", "Queensbury", "NY", "USA");
        Address address2 = new Address("Rua pablo Luiz Santos", "Lafiete", "MG", "Brazil");
        Customer daniel = new Customer("Daniel", address1);
        Customer pedro = new Customer("Pedro", address2);
        Order order1 = new Order(daniel);
        order1.addItem(product1);
        order1.addItem(product3);
        order1.addItem(product5);
        Order order2 = new Order(pedro);
        order2.addItem(product2);
        order2.addItem(product4);

        Console.WriteLine(order1.getPackingLabel()); 
        Console.WriteLine(order1.getShippingLabel());
        Console.WriteLine(order1.totalCost());

        Console.WriteLine(order2.getPackingLabel()); 
        Console.WriteLine(order2.getShippingLabel());
        Console.WriteLine(order2.totalCost());
        
    }
}
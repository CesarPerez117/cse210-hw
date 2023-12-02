using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Here is a Shopping Manager");
        Console.WriteLine("Let's display the shopping orders store");
        Console.WriteLine();
        Thread.Sleep(5000); // this will allow you to check it slowly

        // Address
        Address address1 = new Address("Calle Juan Pablo Duarte","Gazcue","Santo Domingo","RD");
        Address address2 = new Address("El Dorado ST","Phoenix","Arizona","USA");


        // Customers
        // I will anotate 2 customer, with 3 and 4 orders.
        // Customer customer1 = new Customer("Edgar Javier", Address address1 = new Address("","","",""));
        Customer customer1 = new Customer("Edgar Javier", address1);
        Customer customer2 = new Customer("Jonathan Miles", address2);

        // Address 
        // Looking for a functional way to call the address...
        // Address address1 = new Address("","","","");
        // "Cannot use local variable 'address1' before it is declared" that's important...

        // Products 
        // All prices went from Aliexpress
        // for 1st user
        Product product1 = new Product("LP55 Wireless Earbunds",90503,10.42,2);
        Product product2 = new Product("Mini Android 1080p Projector",23513,33.50,1);
        Product product3 = new Product("PowerA Xbox Controller",60737,35.20,2);

        // for 2nd user 
        Product product4 = new Product("Cycling Gloves",80903,16.65,1);
        Product product5 = new Product("Cycling Jersey",82771,12.34,4);
        Product product6 = new Product("Cycling Sunglasses",00916,3.25,2);
        Product product7 = new Product("Bicylci Tailight and Blinkers",89942,16.10,1);

        // Order assignation
        // This is something that Jonathan shared to me in an screenshoot.
        // Is an intelligent usage of the constructor, really good. 
        // Keys add the products to the list and receive the customer as the 2nd parameter.         

        Order order1 = new Order(new List<Product> {product1, product2, product3}, customer1);
        Order order2 = new Order(new List<Product> {product4, product5, product6, product7}, customer2);

        // Organize and Display the orders 
        Console.WriteLine(order1.PackingLabel());
        Thread.Sleep(5000); 
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():f2}");
        Console.WriteLine();
        Thread.Sleep(5000);

        Console.WriteLine(order2.PackingLabel());
        Thread.Sleep(5000);
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost():f2}");
        Console.WriteLine();
    }
}
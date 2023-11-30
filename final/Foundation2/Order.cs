using System;

public class Order
{
    private List<Order> _orders = new List<Order>();
    private List<Order> _products = new List<Order>();
    private int _totalCost;
    public Order()
    {

    }

    public void PackingLabel(string productName, int productID, double productPrice)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"{productName} | {productID} | {productPrice}");
        Console.WriteLine("------------------------------");
    }

    public void ShippingLabel(string customerName, string address)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"{customerName}\n{address}");
        Console.WriteLine("------------------------------");
    }
}
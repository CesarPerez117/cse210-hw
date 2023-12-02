using System;

public class Order
{
    //private List<Order> _orders = new List<Order>();
    private List<Product> _products;
    private Customer _customer;
    private double _totalCost;
    private double _shippingFee;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }   

    public double CalculateTotalCost()
    {
        foreach (var product in _products)
        {
            _totalCost += product.CalculatePrice();
        }
        if (_customer.IsInUSA())
        {
            _shippingFee = 5;
        }
        else
        {
            _shippingFee = 35;
        }
        return _totalCost + _shippingFee;
    }


    // Here is where I will locate the Labels for the products 
    // I had a big problem that I never handled: cannot pass bool to void
    // Looks like when I call the method in the Order Parent class it changes his nature
    // I don't know the reason, but Jonathan found a solution...

    /* public void PackingLabel()
    {   
        foreach (Product product in _products)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Packing Label");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{product.GetProductName()} \nID:{product.GetProductID()} \n${product.GetProductPrice()}");
            Console.WriteLine("------------------------------");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Shipping Label");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Customer: {_customer.GetCustomerName()}\nAddress: {_customer.GetCustomerAddress().GetAddress()}");
        Console.WriteLine("------------------------------");
    }
    */

    // solution consist in make the method an string, and add every string to a variable that 
    // constantly adds the values and return everything ass a display method. 
    // this avoid the "cannot conver bool to void" error
    public string PackingLabel()
    {   
        string packingLabel = "------------------------------\n";
        packingLabel += "Packing Label\n";
        packingLabel += "------------------------------\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductName()} \nID:{product.GetProductID()} \n${product.GetProductPrice()}\nQuantity:{product.GetQuantity()}\n";
        }
        packingLabel += "------------------------------\n";
        
        return packingLabel;
    }

    public string ShippingLabel()
    {   
        string shippingLabel = "------------------------------\n";
        shippingLabel += "Shipping Label\n";
        shippingLabel += "------------------------------\n";
        shippingLabel += $"Customer: {_customer.GetCustomerName()}\nAddress: {_customer.GetCustomerAddress().GetAddress()}\n";
        shippingLabel += "------------------------------\n";
        return shippingLabel;
    }
}
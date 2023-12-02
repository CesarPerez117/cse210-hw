using System;

public class Customer
{
    private string _customerName;
    // private string _address = Address.GetAddress();
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }
    public Address GetCustomerAddress()
    {
        return _address;
    }
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }


}
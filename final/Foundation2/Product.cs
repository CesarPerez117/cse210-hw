using System;

public class Product
{
    private string _productName;
    private int _productID;
    private double _productPrice;
    private int _quantity;
    public Product(string productName, int productID, double productPrice, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _quantity = quantity;
    }

    public double CalculatePrice()
    {
        double _totalPrice = _productPrice * _quantity;
        return _totalPrice;
    }

    // I had problems trying to user the constructor to get the product information to the 
    // packing label in the order class. A solution from my peer jonathan was very simple, 
    // get set with methods. Never thought it in 3 days. :(

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public double GetProductPrice()
    {
        return _productPrice;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}